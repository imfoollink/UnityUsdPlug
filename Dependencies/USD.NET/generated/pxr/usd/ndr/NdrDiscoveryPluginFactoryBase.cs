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
    public class NdrDiscoveryPluginFactoryBase : TfType.FactoryBase
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal NdrDiscoveryPluginFactoryBase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.NdrDiscoveryPluginFactoryBase_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NdrDiscoveryPluginFactoryBase obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~NdrDiscoveryPluginFactoryBase()
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
                        UsdCsPINVOKE.delete_NdrDiscoveryPluginFactoryBase(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public virtual SWIGTYPE_p_TfDeclarePtrsT_NdrDiscoveryPlugin_t__RefPtr New()
        {
            SWIGTYPE_p_TfDeclarePtrsT_NdrDiscoveryPlugin_t__RefPtr ret = new SWIGTYPE_p_TfDeclarePtrsT_NdrDiscoveryPlugin_t__RefPtr(UsdCsPINVOKE.NdrDiscoveryPluginFactoryBase_New(swigCPtr), true);
            return ret;
        }
    }
}
