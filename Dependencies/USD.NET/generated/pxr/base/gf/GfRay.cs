//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class GfRay : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal GfRay(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfRay obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~GfRay()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_GfRay(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public GfRay() : this(UsdCsPINVOKE.new_GfRay__SWIG_0(), true)
        {
        }

        public GfRay(GfVec3d startPoint, GfVec3d direction) : this(UsdCsPINVOKE.new_GfRay__SWIG_1(GfVec3d.getCPtr(startPoint), GfVec3d.getCPtr(direction)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetPointAndDirection(GfVec3d startPoint, GfVec3d direction)
        {
            UsdCsPINVOKE.GfRay_SetPointAndDirection(swigCPtr, GfVec3d.getCPtr(startPoint), GfVec3d.getCPtr(direction));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetEnds(GfVec3d startPoint, GfVec3d endPoint)
        {
            UsdCsPINVOKE.GfRay_SetEnds(swigCPtr, GfVec3d.getCPtr(startPoint), GfVec3d.getCPtr(endPoint));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfVec3d GetStartPoint()
        {
            GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRay_GetStartPoint(swigCPtr), false);
            return ret;
        }

        public GfVec3d GetDirection()
        {
            GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRay_GetDirection(swigCPtr), false);
            return ret;
        }

        public GfVec3d GetPoint(double distance)
        {
            GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRay_GetPoint(swigCPtr, distance), true);
            return ret;
        }

        public GfRay Transform(GfMatrix4d matrix)
        {
            GfRay ret = new GfRay(UsdCsPINVOKE.GfRay_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix)), false);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfVec3d FindClosestPoint(GfVec3d point, out double rayDistance)
        {
            GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRay_FindClosestPoint__SWIG_0(swigCPtr, GfVec3d.getCPtr(point), out rayDistance), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfVec3d FindClosestPoint(GfVec3d point)
        {
            GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRay_FindClosestPoint__SWIG_1(swigCPtr, GfVec3d.getCPtr(point)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance, GfVec3d barycentricCoords, out bool frontFacing, double maxDist)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_0(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance, GfVec3d.getCPtr(barycentricCoords), out frontFacing, maxDist);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance, GfVec3d barycentricCoords, out bool frontFacing)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_1(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance, GfVec3d.getCPtr(barycentricCoords), out frontFacing);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance, GfVec3d barycentricCoords)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_2(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance, GfVec3d.getCPtr(barycentricCoords));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_3(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_4(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfPlane plane, out double distance, out bool frontFacing)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_5(swigCPtr, GfPlane.getCPtr(plane), out distance, out frontFacing);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfPlane plane, out double distance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_6(swigCPtr, GfPlane.getCPtr(plane), out distance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfPlane plane)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_7(swigCPtr, GfPlane.getCPtr(plane));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfRange3d box, out double enterDistance, out double exitDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_8(swigCPtr, GfRange3d.getCPtr(box), out enterDistance, out exitDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfRange3d box, out double enterDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_9(swigCPtr, GfRange3d.getCPtr(box), out enterDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfRange3d box)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_10(swigCPtr, GfRange3d.getCPtr(box));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfBBox3d box, out double enterDistance, out double exitDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_11(swigCPtr, GfBBox3d.getCPtr(box), out enterDistance, out exitDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfBBox3d box, out double enterDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_12(swigCPtr, GfBBox3d.getCPtr(box), out enterDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfBBox3d box)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_13(swigCPtr, GfBBox3d.getCPtr(box));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d center, double radius, out double enterDistance, out double exitDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_14(swigCPtr, GfVec3d.getCPtr(center), radius, out enterDistance, out exitDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d center, double radius, out double enterDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_15(swigCPtr, GfVec3d.getCPtr(center), radius, out enterDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d center, double radius)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_16(swigCPtr, GfVec3d.getCPtr(center), radius);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, out double enterDistance, out double exitDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_17(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, out enterDistance, out exitDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, out double enterDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_18(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, out enterDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d origin, GfVec3d axis, double radius)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_19(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, double height, out double enterDistance, out double exitDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_20(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, height, out enterDistance, out exitDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, double height, out double enterDistance)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_21(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, height, out enterDistance);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, double height)
        {
            bool ret = UsdCsPINVOKE.GfRay_Intersect__SWIG_22(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, height);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool Equals(GfRay lhs, GfRay rhs)
        {
            bool ret = UsdCsPINVOKE.GfRay_Equals(GfRay.getCPtr(lhs), GfRay.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        override public int GetHashCode()
        {
            int ret = UsdCsPINVOKE.GfRay_GetHashCode(swigCPtr);
            return ret;
        }

        public static bool operator==(GfRay lhs, GfRay rhs)
        {
            // The Swig binding glue will re-enter this operator comparing to null, so
            // that case must be handled explicitly to avoid an infinite loop. This is still
            // not great, since it crosses the C#/C++ barrier twice. A better approache might
            // be to return a simple value from C++ that can be compared in C#.
            bool lnull = lhs as object == null;
            bool rnull = rhs as object == null;
            return (lnull == rnull) && ((lnull && rnull) || GfRay.Equals(lhs, rhs));
        }

        public static bool operator!=(GfRay lhs, GfRay rhs)
        {
            return !(lhs == rhs);
        }

        override public bool Equals(object rhs)
        {
            return GfRay.Equals(this, rhs as GfRay);
        }
    }
}
