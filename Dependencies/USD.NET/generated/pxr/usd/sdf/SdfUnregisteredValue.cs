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
    public class SdfUnregisteredValue : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfUnregisteredValue(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfUnregisteredValue obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfUnregisteredValue()
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
                        UsdCsPINVOKE.delete_SdfUnregisteredValue(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SdfUnregisteredValue() : this(UsdCsPINVOKE.new_SdfUnregisteredValue__SWIG_0(), true)
        {
        }

        public SdfUnregisteredValue(string value) : this(UsdCsPINVOKE.new_SdfUnregisteredValue__SWIG_1(value), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfUnregisteredValue(VtDictionary value) : this(UsdCsPINVOKE.new_SdfUnregisteredValue__SWIG_2(VtDictionary.getCPtr(value)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfUnregisteredValue(SdfUnregisteredValueListOp value) : this(UsdCsPINVOKE.new_SdfUnregisteredValue__SWIG_3(SdfUnregisteredValueListOp.getCPtr(value)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public VtValue GetValue()
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfUnregisteredValue_GetValue(swigCPtr), false);
            return ret;
        }
    }
}
