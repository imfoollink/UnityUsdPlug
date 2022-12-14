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
    public class UsdRiPxrRampLightFilter : UsdLuxLightFilter
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdRiPxrRampLightFilter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiPxrRampLightFilter_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiPxrRampLightFilter obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdRiPxrRampLightFilter()
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
                        UsdCsPINVOKE.delete_UsdRiPxrRampLightFilter(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdRiPxrRampLightFilter(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiPxrRampLightFilter__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdRiPxrRampLightFilter() : this(UsdCsPINVOKE.new_UsdRiPxrRampLightFilter__SWIG_1(), true)
        {
        }

        public UsdRiPxrRampLightFilter(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiPxrRampLightFilter__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public new static UsdRiPxrRampLightFilter Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiPxrRampLightFilter ret = new UsdRiPxrRampLightFilter(UsdCsPINVOKE.UsdRiPxrRampLightFilter_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new static UsdRiPxrRampLightFilter Define(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiPxrRampLightFilter ret = new UsdRiPxrRampLightFilter(UsdCsPINVOKE.UsdRiPxrRampLightFilter_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetRampModeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetRampModeAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRampModeAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateRampModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRampModeAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateRampModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRampModeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateRampModeAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetBeginDistanceAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetBeginDistanceAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateBeginDistanceAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateBeginDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateBeginDistanceAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateBeginDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateBeginDistanceAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateBeginDistanceAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetEndDistanceAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetEndDistanceAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateEndDistanceAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateEndDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateEndDistanceAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateEndDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateEndDistanceAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateEndDistanceAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetFalloffAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetFalloffAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateFalloffAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetFalloffKnotsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetFalloffKnotsAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateFalloffKnotsAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffKnotsAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffKnotsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffKnotsAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetFalloffFloatsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetFalloffFloatsAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateFalloffFloatsAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffFloatsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffFloatsAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffFloatsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffFloatsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffFloatsAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetFalloffInterpolationAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetFalloffInterpolationAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateFalloffInterpolationAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffInterpolationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffInterpolationAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffInterpolationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateFalloffInterpolationAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateFalloffInterpolationAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorRampAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetColorRampAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorRampAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorRampKnotsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetColorRampKnotsAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorRampKnotsAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampKnotsAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampKnotsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampKnotsAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorRampColorsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetColorRampColorsAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorRampColorsAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampColorsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampColorsAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampColorsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampColorsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampColorsAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorRampInterpolationAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_GetColorRampInterpolationAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorRampInterpolationAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampInterpolationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampInterpolationAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampInterpolationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorRampInterpolationAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrRampLightFilter_CreateColorRampInterpolationAttr__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}
