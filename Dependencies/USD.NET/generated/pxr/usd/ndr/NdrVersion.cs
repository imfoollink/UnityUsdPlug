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
    public class NdrVersion : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal NdrVersion(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NdrVersion obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~NdrVersion()
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
                        UsdCsPINVOKE.delete_NdrVersion(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public NdrVersion() : this(UsdCsPINVOKE.new_NdrVersion__SWIG_0(), true)
        {
        }

        public NdrVersion(int major, int minor) : this(UsdCsPINVOKE.new_NdrVersion__SWIG_1(major, minor), true)
        {
        }

        public NdrVersion(int major) : this(UsdCsPINVOKE.new_NdrVersion__SWIG_2(major), true)
        {
        }

        public NdrVersion(string x) : this(UsdCsPINVOKE.new_NdrVersion__SWIG_3(x), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public NdrVersion GetAsDefault()
        {
            NdrVersion ret = new NdrVersion(UsdCsPINVOKE.NdrVersion_GetAsDefault(swigCPtr), true);
            return ret;
        }

        public int GetMajor()
        {
            int ret = UsdCsPINVOKE.NdrVersion_GetMajor(swigCPtr);
            return ret;
        }

        public int GetMinor()
        {
            int ret = UsdCsPINVOKE.NdrVersion_GetMinor(swigCPtr);
            return ret;
        }

        public bool IsDefault()
        {
            bool ret = UsdCsPINVOKE.NdrVersion_IsDefault(swigCPtr);
            return ret;
        }

        public string GetString()
        {
            string ret = UsdCsPINVOKE.NdrVersion_GetString(swigCPtr);
            return ret;
        }

        public string GetStringSuffix()
        {
            string ret = UsdCsPINVOKE.NdrVersion_GetStringSuffix(swigCPtr);
            return ret;
        }

        public uint GetHash()
        {
            uint ret = UsdCsPINVOKE.NdrVersion_GetHash(swigCPtr);
            return ret;
        }
    }
}
