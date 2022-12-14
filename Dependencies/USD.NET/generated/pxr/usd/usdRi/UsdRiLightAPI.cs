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
    public class UsdRiLightAPI : UsdAPISchemaBase
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdRiLightAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiLightAPI_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiLightAPI obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdRiLightAPI()
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
                        UsdCsPINVOKE.delete_UsdRiLightAPI(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdRiLightAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiLightAPI__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdRiLightAPI() : this(UsdCsPINVOKE.new_UsdRiLightAPI__SWIG_1(), true)
        {
        }

        public UsdRiLightAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiLightAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiLightAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiLightAPI_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public static UsdRiLightAPI Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiLightAPI ret = new UsdRiLightAPI(UsdCsPINVOKE.UsdRiLightAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static UsdRiLightAPI Apply(UsdPrim prim)
        {
            UsdRiLightAPI ret = new UsdRiLightAPI(UsdCsPINVOKE.UsdRiLightAPI_Apply(UsdPrim.getCPtr(prim)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetRiSamplingFixedSampleCountAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_GetRiSamplingFixedSampleCountAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiSamplingFixedSampleCountAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiSamplingFixedSampleCountAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiSamplingFixedSampleCountAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiSamplingFixedSampleCountAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiSamplingFixedSampleCountAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiSamplingFixedSampleCountAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRiSamplingImportanceMultiplierAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_GetRiSamplingImportanceMultiplierAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiSamplingImportanceMultiplierAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiSamplingImportanceMultiplierAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiSamplingImportanceMultiplierAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiSamplingImportanceMultiplierAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiSamplingImportanceMultiplierAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiSamplingImportanceMultiplierAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRiIntensityNearDistAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_GetRiIntensityNearDistAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiIntensityNearDistAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiIntensityNearDistAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiIntensityNearDistAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiIntensityNearDistAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiIntensityNearDistAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiIntensityNearDistAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRiLightGroupAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_GetRiLightGroupAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiLightGroupAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiLightGroupAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiLightGroupAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiLightGroupAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiLightGroupAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiLightGroupAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRiShadowThinShadowAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_GetRiShadowThinShadowAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiShadowThinShadowAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiShadowThinShadowAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiShadowThinShadowAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiShadowThinShadowAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiShadowThinShadowAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiShadowThinShadowAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRiTraceLightPathsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_GetRiTraceLightPathsAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiTraceLightPathsAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiTraceLightPathsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiTraceLightPathsAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiTraceLightPathsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiTraceLightPathsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightAPI_CreateRiTraceLightPathsAttr__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}
