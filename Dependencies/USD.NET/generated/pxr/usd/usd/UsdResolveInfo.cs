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
    public class UsdResolveInfo : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdResolveInfo(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdResolveInfo obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdResolveInfo()
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
                        UsdCsPINVOKE.delete_UsdResolveInfo(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdResolveInfo() : this(UsdCsPINVOKE.new_UsdResolveInfo(), true)
        {
        }

        public UsdResolveInfoSource GetSource()
        {
            UsdResolveInfoSource ret = (UsdResolveInfoSource)UsdCsPINVOKE.UsdResolveInfo_GetSource(swigCPtr);
            return ret;
        }

        public bool HasAuthoredValueOpinion()
        {
            bool ret = UsdCsPINVOKE.UsdResolveInfo_HasAuthoredValueOpinion(swigCPtr);
            return ret;
        }

        public bool HasAuthoredValue()
        {
            bool ret = UsdCsPINVOKE.UsdResolveInfo_HasAuthoredValue(swigCPtr);
            return ret;
        }

        public PcpNodeRef GetNode()
        {
            PcpNodeRef ret = new PcpNodeRef(UsdCsPINVOKE.UsdResolveInfo_GetNode(swigCPtr), true);
            return ret;
        }

        public bool ValueIsBlocked()
        {
            bool ret = UsdCsPINVOKE.UsdResolveInfo_ValueIsBlocked(swigCPtr);
            return ret;
        }
    }
}
