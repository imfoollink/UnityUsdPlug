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
    public class UsdSkelInbetweenShape : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdSkelInbetweenShape(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelInbetweenShape obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdSkelInbetweenShape()
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
                        UsdCsPINVOKE.delete_UsdSkelInbetweenShape(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdSkelInbetweenShape() : this(UsdCsPINVOKE.new_UsdSkelInbetweenShape__SWIG_0(), true)
        {
        }

        public UsdSkelInbetweenShape(UsdAttribute attr) : this(UsdCsPINVOKE.new_UsdSkelInbetweenShape__SWIG_1(UsdAttribute.getCPtr(attr)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool GetWeight(SWIGTYPE_p_float weight)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_GetWeight(swigCPtr, SWIGTYPE_p_float.getCPtr(weight));
            return ret;
        }

        public bool SetWeight(float weight)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_SetWeight(swigCPtr, weight);
            return ret;
        }

        public bool HasAuthoredWeight()
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_HasAuthoredWeight(swigCPtr);
            return ret;
        }

        public bool GetOffsets(VtVec3fArray offsets)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_GetOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
            return ret;
        }

        public bool SetOffsets(VtVec3fArray offsets)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_SetOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetNormalOffsetsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelInbetweenShape_GetNormalOffsetsAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateNormalOffsetsAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateNormalOffsetsAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_1(swigCPtr), true);
            return ret;
        }

        public bool GetNormalOffsets(VtVec3fArray offsets)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_GetNormalOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
            return ret;
        }

        public bool SetNormalOffsets(VtVec3fArray offsets)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_SetNormalOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool IsInbetween(UsdAttribute attr)
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_IsInbetween(UsdAttribute.getCPtr(attr));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelInbetweenShape_GetAttr(swigCPtr), false);
            return ret;
        }

        public bool IsDefined()
        {
            bool ret = UsdCsPINVOKE.UsdSkelInbetweenShape_IsDefined(swigCPtr);
            return ret;
        }
    }
}
