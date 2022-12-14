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
    public class UsdLuxLight : UsdGeomXformable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdLuxLight(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdLuxLight_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdLuxLight obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdLuxLight()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdLuxLight(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdLuxLight(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdLuxLight__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdLuxLight() : this(UsdCsPINVOKE.new_UsdLuxLight__SWIG_1(), true)
        {
        }

        public UsdLuxLight(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdLuxLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxLight_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxLight_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public new static UsdLuxLight Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdLuxLight ret = new UsdLuxLight(UsdCsPINVOKE.UsdLuxLight_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetIntensityAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetIntensityAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateIntensityAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateIntensityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateIntensityAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateIntensityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateIntensityAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateIntensityAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetExposureAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetExposureAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateExposureAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateExposureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateExposureAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateExposureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateExposureAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateExposureAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetDiffuseAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetDiffuseAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateDiffuseAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateDiffuseAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateDiffuseAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateDiffuseAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateDiffuseAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateDiffuseAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetSpecularAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetSpecularAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateSpecularAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateSpecularAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateSpecularAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateSpecularAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateSpecularAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateSpecularAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetNormalizeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetNormalizeAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateNormalizeAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateNormalizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateNormalizeAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateNormalizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateNormalizeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateNormalizeAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetColorAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateColorAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetEnableColorTemperatureAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetEnableColorTemperatureAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateEnableColorTemperatureAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateEnableColorTemperatureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateEnableColorTemperatureAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateEnableColorTemperatureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateEnableColorTemperatureAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateEnableColorTemperatureAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorTemperatureAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_GetColorTemperatureAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorTemperatureAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateColorTemperatureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorTemperatureAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateColorTemperatureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorTemperatureAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxLight_CreateColorTemperatureAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdRelationship GetFiltersRel()
        {
            UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxLight_GetFiltersRel(swigCPtr), true);
            return ret;
        }

        public UsdRelationship CreateFiltersRel()
        {
            UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxLight_CreateFiltersRel(swigCPtr), true);
            return ret;
        }

        public GfVec3f ComputeBaseEmission()
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.UsdLuxLight_ComputeBaseEmission(swigCPtr), true);
            return ret;
        }

        public UsdCollectionAPI GetLightLinkCollectionAPI()
        {
            UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdLuxLight_GetLightLinkCollectionAPI(swigCPtr), true);
            return ret;
        }

        public UsdCollectionAPI GetShadowLinkCollectionAPI()
        {
            UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdLuxLight_GetShadowLinkCollectionAPI(swigCPtr), true);
            return ret;
        }
    }
}
