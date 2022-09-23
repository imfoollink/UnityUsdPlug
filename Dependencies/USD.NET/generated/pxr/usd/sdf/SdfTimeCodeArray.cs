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
    public class SdfTimeCodeArray : Vt_ArrayBase
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal SdfTimeCodeArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.SdfTimeCodeArray_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfTimeCodeArray obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfTimeCodeArray()
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
                        UsdCsPINVOKE.delete_SdfTimeCodeArray(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public SdfTimeCode this[int index]
        {
            get { return GetValue(index); }
            set { SetValue(index, value); }
        }

        public SdfTimeCodeArray() : this(UsdCsPINVOKE.new_SdfTimeCodeArray__SWIG_0(), true)
        {
        }

        public SdfTimeCodeArray(SdfTimeCodeArray other) : this(UsdCsPINVOKE.new_SdfTimeCodeArray__SWIG_1(SdfTimeCodeArray.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfTimeCodeArray(uint n) : this(UsdCsPINVOKE.new_SdfTimeCodeArray__SWIG_3(n), true)
        {
        }

        public SdfTimeCodeArray(uint n, SdfTimeCode value) : this(UsdCsPINVOKE.new_SdfTimeCodeArray__SWIG_4(n, SdfTimeCode.getCPtr(value)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void push_back(SdfTimeCode elem)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_push_back(swigCPtr, SdfTimeCode.getCPtr(elem));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void pop_back()
        {
            UsdCsPINVOKE.SdfTimeCodeArray_pop_back(swigCPtr);
        }

        public uint size()
        {
            uint ret = UsdCsPINVOKE.SdfTimeCodeArray_size(swigCPtr);
            return ret;
        }

        public uint capacity()
        {
            uint ret = UsdCsPINVOKE.SdfTimeCodeArray_capacity(swigCPtr);
            return ret;
        }

        public bool empty()
        {
            bool ret = UsdCsPINVOKE.SdfTimeCodeArray_empty(swigCPtr);
            return ret;
        }

        public void reserve(uint num)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_reserve(swigCPtr, num);
        }

        public void resize(uint newSize)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_resize(swigCPtr, newSize);
        }

        public void clear()
        {
            UsdCsPINVOKE.SdfTimeCodeArray_clear(swigCPtr);
        }

        public void assign(uint n, SdfTimeCode fill)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_assign(swigCPtr, n, SdfTimeCode.getCPtr(fill));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void swap(SdfTimeCodeArray other)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_swap(swigCPtr, SdfTimeCodeArray.getCPtr(other));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool IsIdentical(SdfTimeCodeArray other)
        {
            bool ret = UsdCsPINVOKE.SdfTimeCodeArray_IsIdentical(swigCPtr, SdfTimeCodeArray.getCPtr(other));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool Equals(SdfTimeCodeArray lhs, SdfTimeCodeArray rhs)
        {
            bool ret = UsdCsPINVOKE.SdfTimeCodeArray_Equals(SdfTimeCodeArray.getCPtr(lhs), SdfTimeCodeArray.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public override string ToString()
        {
            string ret = UsdCsPINVOKE.SdfTimeCodeArray_ToString(swigCPtr);
            return ret;
        }

        public void CopyToArray(SdfTimeCode[] dest)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_CopyToArray__SWIG_0(swigCPtr, dest);
        }

        public void CopyFromArray(SdfTimeCode[] src)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_CopyFromArray__SWIG_0(swigCPtr, src);
        }

        public void CopyToArray(System.IntPtr dest)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_CopyToArray__SWIG_1(swigCPtr, dest);
        }

        public void CopyFromArray(System.IntPtr src)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_CopyFromArray__SWIG_1(swigCPtr, src);
        }

        protected SdfTimeCode GetValue(int index)
        {
            SdfTimeCode ret = new SdfTimeCode(UsdCsPINVOKE.SdfTimeCodeArray_GetValue(swigCPtr, index), false);
            return ret;
        }

        protected void SetValue(int index, SdfTimeCode value)
        {
            UsdCsPINVOKE.SdfTimeCodeArray_SetValue(swigCPtr, index, SdfTimeCode.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
