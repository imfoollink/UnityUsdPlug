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
    public class SdfUInt64ListOp : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfUInt64ListOp(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfUInt64ListOp obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfUInt64ListOp()
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
                        UsdCsPINVOKE.delete_SdfUInt64ListOp(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public static SdfUInt64ListOp CreateExplicit(StdUInt64Vector explicitItems)
        {
            SdfUInt64ListOp ret = new SdfUInt64ListOp(UsdCsPINVOKE.SdfUInt64ListOp_CreateExplicit__SWIG_0(StdUInt64Vector.getCPtr(explicitItems)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfUInt64ListOp CreateExplicit()
        {
            SdfUInt64ListOp ret = new SdfUInt64ListOp(UsdCsPINVOKE.SdfUInt64ListOp_CreateExplicit__SWIG_1(), true);
            return ret;
        }

        public static SdfUInt64ListOp Create(StdUInt64Vector prependedItems, StdUInt64Vector appendedItems, StdUInt64Vector deletedItems)
        {
            SdfUInt64ListOp ret = new SdfUInt64ListOp(UsdCsPINVOKE.SdfUInt64ListOp_Create__SWIG_0(StdUInt64Vector.getCPtr(prependedItems), StdUInt64Vector.getCPtr(appendedItems), StdUInt64Vector.getCPtr(deletedItems)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfUInt64ListOp Create(StdUInt64Vector prependedItems, StdUInt64Vector appendedItems)
        {
            SdfUInt64ListOp ret = new SdfUInt64ListOp(UsdCsPINVOKE.SdfUInt64ListOp_Create__SWIG_1(StdUInt64Vector.getCPtr(prependedItems), StdUInt64Vector.getCPtr(appendedItems)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfUInt64ListOp Create(StdUInt64Vector prependedItems)
        {
            SdfUInt64ListOp ret = new SdfUInt64ListOp(UsdCsPINVOKE.SdfUInt64ListOp_Create__SWIG_2(StdUInt64Vector.getCPtr(prependedItems)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfUInt64ListOp Create()
        {
            SdfUInt64ListOp ret = new SdfUInt64ListOp(UsdCsPINVOKE.SdfUInt64ListOp_Create__SWIG_3(), true);
            return ret;
        }

        public SdfUInt64ListOp() : this(UsdCsPINVOKE.new_SdfUInt64ListOp(), true)
        {
        }

        public void Swap(SdfUInt64ListOp rhs)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_Swap(swigCPtr, SdfUInt64ListOp.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool HasKeys()
        {
            bool ret = UsdCsPINVOKE.SdfUInt64ListOp_HasKeys(swigCPtr);
            return ret;
        }

        public bool HasItem(ulong item)
        {
            bool ret = UsdCsPINVOKE.SdfUInt64ListOp_HasItem(swigCPtr, item);
            return ret;
        }

        public bool IsExplicit()
        {
            bool ret = UsdCsPINVOKE.SdfUInt64ListOp_IsExplicit(swigCPtr);
            return ret;
        }

        public StdUInt64Vector GetExplicitItems()
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetExplicitItems(swigCPtr), false);
            return ret;
        }

        public StdUInt64Vector GetAddedItems()
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetAddedItems(swigCPtr), false);
            return ret;
        }

        public StdUInt64Vector GetPrependedItems()
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetPrependedItems(swigCPtr), false);
            return ret;
        }

        public StdUInt64Vector GetAppendedItems()
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetAppendedItems(swigCPtr), false);
            return ret;
        }

        public StdUInt64Vector GetDeletedItems()
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetDeletedItems(swigCPtr), false);
            return ret;
        }

        public StdUInt64Vector GetOrderedItems()
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetOrderedItems(swigCPtr), false);
            return ret;
        }

        public StdUInt64Vector GetItems(SdfListOpType type)
        {
            StdUInt64Vector ret = new StdUInt64Vector(UsdCsPINVOKE.SdfUInt64ListOp_GetItems(swigCPtr, (int)type), false);
            return ret;
        }

        public void SetExplicitItems(StdUInt64Vector items)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetExplicitItems(swigCPtr, StdUInt64Vector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetAddedItems(StdUInt64Vector items)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetAddedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetPrependedItems(StdUInt64Vector items)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetPrependedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetAppendedItems(StdUInt64Vector items)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetAppendedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetDeletedItems(StdUInt64Vector items)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetDeletedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetOrderedItems(StdUInt64Vector items)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetOrderedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetItems(StdUInt64Vector items, SdfListOpType type)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_SetItems(swigCPtr, StdUInt64Vector.getCPtr(items), (int)type);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Clear()
        {
            UsdCsPINVOKE.SdfUInt64ListOp_Clear(swigCPtr);
        }

        public void ClearAndMakeExplicit()
        {
            UsdCsPINVOKE.SdfUInt64ListOp_ClearAndMakeExplicit(swigCPtr);
        }

        public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdUInt64Vector newItems)
        {
            bool ret = UsdCsPINVOKE.SdfUInt64ListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdUInt64Vector.getCPtr(newItems));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void ComposeOperations(SdfUInt64ListOp stronger, SdfListOpType op)
        {
            UsdCsPINVOKE.SdfUInt64ListOp_ComposeOperations(swigCPtr, SdfUInt64ListOp.getCPtr(stronger), (int)op);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
