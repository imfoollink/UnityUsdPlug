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
    public class UsdInherits : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdInherits(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdInherits obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdInherits()
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
                        UsdCsPINVOKE.delete_UsdInherits(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public bool AddInherit(SdfPath primPath, UsdListPosition position)
        {
            bool ret = UsdCsPINVOKE.UsdInherits_AddInherit__SWIG_0(swigCPtr, SdfPath.getCPtr(primPath), (int)position);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool AddInherit(SdfPath primPath)
        {
            bool ret = UsdCsPINVOKE.UsdInherits_AddInherit__SWIG_1(swigCPtr, SdfPath.getCPtr(primPath));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool RemoveInherit(SdfPath primPath)
        {
            bool ret = UsdCsPINVOKE.UsdInherits_RemoveInherit(swigCPtr, SdfPath.getCPtr(primPath));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearInherits()
        {
            bool ret = UsdCsPINVOKE.UsdInherits_ClearInherits(swigCPtr);
            return ret;
        }

        public bool SetInherits(SdfPathVector items)
        {
            bool ret = UsdCsPINVOKE.UsdInherits_SetInherits(swigCPtr, SdfPathVector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfPathVector GetAllDirectInherits()
        {
            SdfPathVector ret = new SdfPathVector(UsdCsPINVOKE.UsdInherits_GetAllDirectInherits(swigCPtr), true);
            return ret;
        }

        public UsdPrim GetPrim()
        {
            UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdInherits_GetPrim__SWIG_0(swigCPtr), false);
            return ret;
        }
    }
}
