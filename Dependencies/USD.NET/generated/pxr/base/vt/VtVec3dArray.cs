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
    [Preserve]
    public class VtVec3dArray : Vt_ArrayBase
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal VtVec3dArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtVec3dArray_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtVec3dArray obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~VtVec3dArray()
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
                        UsdCsPINVOKE.delete_VtVec3dArray(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public GfVec3d this[int index]
        {
            get { return GetValue(index); }
            set { SetValue(index, value); }
        }

        public VtVec3dArray() : this(UsdCsPINVOKE.new_VtVec3dArray__SWIG_0(), true)
        {
        }

        public VtVec3dArray(VtVec3dArray other) : this(UsdCsPINVOKE.new_VtVec3dArray__SWIG_1(VtVec3dArray.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public VtVec3dArray(uint n) : this(UsdCsPINVOKE.new_VtVec3dArray__SWIG_3(n), true)
        {
        }

        public VtVec3dArray(uint n, GfVec3d value) : this(UsdCsPINVOKE.new_VtVec3dArray__SWIG_4(n, GfVec3d.getCPtr(value)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void push_back(GfVec3d elem)
        {
            UsdCsPINVOKE.VtVec3dArray_push_back(swigCPtr, GfVec3d.getCPtr(elem));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void pop_back()
        {
            UsdCsPINVOKE.VtVec3dArray_pop_back(swigCPtr);
        }

        public uint size()
        {
            uint ret = UsdCsPINVOKE.VtVec3dArray_size(swigCPtr);
            return ret;
        }

        public uint capacity()
        {
            uint ret = UsdCsPINVOKE.VtVec3dArray_capacity(swigCPtr);
            return ret;
        }

        public bool empty()
        {
            bool ret = UsdCsPINVOKE.VtVec3dArray_empty(swigCPtr);
            return ret;
        }

        public void reserve(uint num)
        {
            UsdCsPINVOKE.VtVec3dArray_reserve(swigCPtr, num);
        }

        public void resize(uint newSize)
        {
            UsdCsPINVOKE.VtVec3dArray_resize(swigCPtr, newSize);
        }

        public void clear()
        {
            UsdCsPINVOKE.VtVec3dArray_clear(swigCPtr);
        }

        public void assign(uint n, GfVec3d fill)
        {
            UsdCsPINVOKE.VtVec3dArray_assign(swigCPtr, n, GfVec3d.getCPtr(fill));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void swap(VtVec3dArray other)
        {
            UsdCsPINVOKE.VtVec3dArray_swap(swigCPtr, VtVec3dArray.getCPtr(other));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool IsIdentical(VtVec3dArray other)
        {
            bool ret = UsdCsPINVOKE.VtVec3dArray_IsIdentical(swigCPtr, VtVec3dArray.getCPtr(other));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool Equals(VtVec3dArray lhs, VtVec3dArray rhs)
        {
            bool ret = UsdCsPINVOKE.VtVec3dArray_Equals(VtVec3dArray.getCPtr(lhs), VtVec3dArray.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public override string ToString()
        {
            string ret = UsdCsPINVOKE.VtVec3dArray_ToString(swigCPtr);
            return ret;
        }

        public void CopyToArray(GfVec3d[] dest)
        {
            UsdCsPINVOKE.VtVec3dArray_CopyToArray__SWIG_0(swigCPtr, dest);
        }

        public void CopyFromArray(GfVec3d[] src)
        {
            UsdCsPINVOKE.VtVec3dArray_CopyFromArray__SWIG_0(swigCPtr, src);
        }

        public void CopyToArray(System.IntPtr dest)
        {
            UsdCsPINVOKE.VtVec3dArray_CopyToArray__SWIG_1(swigCPtr, dest);
        }

        public void CopyFromArray(System.IntPtr src)
        {
            UsdCsPINVOKE.VtVec3dArray_CopyFromArray__SWIG_1(swigCPtr, src);
        }

        protected GfVec3d GetValue(int index)
        {
            GfVec3d ret = new GfVec3d(UsdCsPINVOKE.VtVec3dArray_GetValue(swigCPtr, index), false);
            return ret;
        }

        protected void SetValue(int index, GfVec3d value)
        {
            UsdCsPINVOKE.VtVec3dArray_SetValue(swigCPtr, index, GfVec3d.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
