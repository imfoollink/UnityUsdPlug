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
    public class SdfNamespaceEdit : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfNamespaceEdit(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfNamespaceEdit obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfNamespaceEdit()
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
                        UsdCsPINVOKE.delete_SdfNamespaceEdit(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SdfNamespaceEdit() : this(UsdCsPINVOKE.new_SdfNamespaceEdit__SWIG_0(), true)
        {
        }

        public SdfNamespaceEdit(SdfPath currentPath_, SdfPath newPath_, int index_) : this(UsdCsPINVOKE.new_SdfNamespaceEdit__SWIG_1(SdfPath.getCPtr(currentPath_), SdfPath.getCPtr(newPath_), index_), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfNamespaceEdit(SdfPath currentPath_, SdfPath newPath_) : this(UsdCsPINVOKE.new_SdfNamespaceEdit__SWIG_2(SdfPath.getCPtr(currentPath_), SdfPath.getCPtr(newPath_)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static SdfNamespaceEdit Remove(SdfPath currentPath)
        {
            SdfNamespaceEdit ret = new SdfNamespaceEdit(UsdCsPINVOKE.SdfNamespaceEdit_Remove(SdfPath.getCPtr(currentPath)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfNamespaceEdit Rename(SdfPath currentPath, TfToken name)
        {
            SdfNamespaceEdit ret = new SdfNamespaceEdit(UsdCsPINVOKE.SdfNamespaceEdit_Rename(SdfPath.getCPtr(currentPath), TfToken.getCPtr(name)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfNamespaceEdit Reorder(SdfPath currentPath, int index)
        {
            SdfNamespaceEdit ret = new SdfNamespaceEdit(UsdCsPINVOKE.SdfNamespaceEdit_Reorder(SdfPath.getCPtr(currentPath), index), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfNamespaceEdit Reparent(SdfPath currentPath, SdfPath newParentPath, int index)
        {
            SdfNamespaceEdit ret = new SdfNamespaceEdit(UsdCsPINVOKE.SdfNamespaceEdit_Reparent(SdfPath.getCPtr(currentPath), SdfPath.getCPtr(newParentPath), index), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SdfNamespaceEdit ReparentAndRename(SdfPath currentPath, SdfPath newParentPath, TfToken name, int index)
        {
            SdfNamespaceEdit ret = new SdfNamespaceEdit(UsdCsPINVOKE.SdfNamespaceEdit_ReparentAndRename(SdfPath.getCPtr(currentPath), SdfPath.getCPtr(newParentPath), TfToken.getCPtr(name), index), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfPath currentPath
        {
            set
            {
                UsdCsPINVOKE.SdfNamespaceEdit_currentPath_set(swigCPtr, SdfPath.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = UsdCsPINVOKE.SdfNamespaceEdit_currentPath_get(swigCPtr);
                SdfPath ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPath(cPtr, false);
                return ret;
            }
        }

        public SdfPath newPath
        {
            set
            {
                UsdCsPINVOKE.SdfNamespaceEdit_newPath_set(swigCPtr, SdfPath.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = UsdCsPINVOKE.SdfNamespaceEdit_newPath_get(swigCPtr);
                SdfPath ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPath(cPtr, false);
                return ret;
            }
        }

        public int index
        {
            set
            {
                UsdCsPINVOKE.SdfNamespaceEdit_index_set(swigCPtr, value);
            }
            get
            {
                int ret = UsdCsPINVOKE.SdfNamespaceEdit_index_get(swigCPtr);
                return ret;
            }
        }

        public static readonly int AtEnd = UsdCsPINVOKE.SdfNamespaceEdit_AtEnd_get();
        public static readonly int Same = UsdCsPINVOKE.SdfNamespaceEdit_Same_get();
    }
}
