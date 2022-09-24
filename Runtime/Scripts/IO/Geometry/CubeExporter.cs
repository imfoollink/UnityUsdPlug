using UnityEngine;
using USD.NET;
using USD.NET.Unity;

namespace Unity.Formats.USD
{
    public static class CubeExporter
    {
        public static void ExportCube(ObjectContext objContext, ExportContext exportContext)
        {
            UnityEngine.Profiling.Profiler.BeginSample("USD-Party: Cube Conversion");

            Debug.Log("cube exporter");
            // CubeSample sample = (CubeSample)objContext.sample;

            XformSample sample = (XformSample)objContext.sample;
            var localRot = objContext.gameObject.transform.localRotation;
            var localScale = objContext.gameObject.transform.localScale;
            var path = new pxr.SdfPath(objContext.path);

            // If exporting for Z-Up, rotate the world.
            bool correctZUp = exportContext.scene.UpAxis == Scene.UpAxes.Z;

            sample.transform = GetLocalTransformMatrix(
                objContext.gameObject.transform,
                correctZUp,
                path.IsRootPrimPath(),
                exportContext.basisTransform);


            UnityEngine.Profiling.Profiler.EndSample();

            UnityEngine.Profiling.Profiler.BeginSample("USD-Party: Cube Write");
            exportContext.scene.Write(path, sample);
            UnityEngine.Profiling.Profiler.EndSample();
        }

        public static Matrix4x4 GetLocalTransformMatrix(
            Transform tr,
            bool correctZUp,
            bool isRootPrim,
            BasisTransformation conversionType)
        {
            var localRot = tr.localRotation;
            bool fastConvert = conversionType == BasisTransformation.FastWithNegativeScale;

            if (correctZUp && isRootPrim)
            {
                float invert = fastConvert ? 1 : -1;
                localRot = localRot * Quaternion.AngleAxis(invert * 90, Vector3.right);
            }

            var mat = Matrix4x4.TRS(tr.localPosition, localRot, tr.localScale);

            // Unity uses a forward vector that matches DirectX, but USD matches OpenGL, so a change of
            // basis is required. There are shortcuts, but this is fully general.
            //
            // Here we can either put a partial conversion at the root (fast & dangerous) or convert the
            // entire hierarchy, along with the points, normals and triangle winding. The benefit of the
            // full conversion is that there are no negative scales left in the hierarchy.
            //
            // Note that this is the correct partial conversion for the root transforms, however the
            // camera and light matrices must contain the other half of the conversion
            // (e.g. mat * basisChangeInverse).
            if (fastConvert && isRootPrim)
            {
                // Partial change of basis.
                var basisChange = Matrix4x4.identity;
                // Invert the forward vector.
                basisChange[2, 2] = -1;
                mat = basisChange * mat;
            }
            else if (!fastConvert)
            {
                // Full change of basis.
                mat = UnityTypeConverter.ChangeBasis(mat);
            }

            return mat;
        }
    }
}
