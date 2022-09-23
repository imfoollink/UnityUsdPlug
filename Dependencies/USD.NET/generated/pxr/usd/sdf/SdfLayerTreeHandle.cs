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
    public class SdfLayerTreeHandle : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfLayerTreeHandle(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfLayerTreeHandle obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfLayerTreeHandle()
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
                        UsdCsPINVOKE.delete_SdfLayerTreeHandle(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SdfLayerTreeHandle(SdfLayerTree layer) : this(UsdCsPINVOKE.new_SdfLayerTreeHandle(SdfLayerTree.getCPtr(layer)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfLayerTree __deref__()
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.SdfLayerTreeHandle___deref__(swigCPtr);
            SdfLayerTree ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerTree(cPtr, true);
            return ret;
        }

        public SdfLayerTreeHandle New(SdfLayerHandle layer, SdfLayerTreeHandleVector childTrees, SdfLayerOffset cumulativeOffset)
        {
            SdfLayerTreeHandle ret = new SdfLayerTreeHandle(UsdCsPINVOKE.SdfLayerTreeHandle_New__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(layer), SdfLayerTreeHandleVector.getCPtr(childTrees), SdfLayerOffset.getCPtr(cumulativeOffset)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfLayerTreeHandle New(SdfLayerHandle layer, SdfLayerTreeHandleVector childTrees)
        {
            SdfLayerTreeHandle ret = new SdfLayerTreeHandle(UsdCsPINVOKE.SdfLayerTreeHandle_New__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(layer), SdfLayerTreeHandleVector.getCPtr(childTrees)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfLayerHandle GetLayer()
        {
            SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.SdfLayerTreeHandle_GetLayer(swigCPtr), false);
            return ret;
        }

        public SdfLayerOffset GetOffset()
        {
            SdfLayerOffset ret = new SdfLayerOffset(UsdCsPINVOKE.SdfLayerTreeHandle_GetOffset(swigCPtr), false);
            return ret;
        }

        public SdfLayerTreeHandleVector GetChildTrees()
        {
            SdfLayerTreeHandleVector ret = new SdfLayerTreeHandleVector(UsdCsPINVOKE.SdfLayerTreeHandle_GetChildTrees(swigCPtr), false);
            return ret;
        }
    }
}
