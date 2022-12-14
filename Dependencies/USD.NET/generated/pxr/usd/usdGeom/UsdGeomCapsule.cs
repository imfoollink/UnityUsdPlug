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
    public class UsdGeomCapsule : UsdGeomGprim
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdGeomCapsule(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomCapsule_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomCapsule obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdGeomCapsule()
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
                        UsdCsPINVOKE.delete_UsdGeomCapsule(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdGeomCapsule(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomCapsule__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdGeomCapsule() : this(UsdCsPINVOKE.new_UsdGeomCapsule__SWIG_1(), true)
        {
        }

        public UsdGeomCapsule(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdGeomCapsule__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomCapsule_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomCapsule_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public new static UsdGeomCapsule Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdGeomCapsule ret = new UsdGeomCapsule(UsdCsPINVOKE.UsdGeomCapsule_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static UsdGeomCapsule Define(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdGeomCapsule ret = new UsdGeomCapsule(UsdCsPINVOKE.UsdGeomCapsule_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetHeightAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_GetHeightAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateHeightAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateHeightAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateHeightAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateHeightAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateHeightAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateHeightAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRadiusAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_GetRadiusAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRadiusAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRadiusAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateRadiusAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetAxisAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_GetAxisAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateAxisAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateAxisAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateAxisAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateAxisAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateAxisAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateAxisAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public new UsdAttribute GetExtentAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_GetExtentAttr(swigCPtr), true);
            return ret;
        }

        public new UsdAttribute CreateExtentAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateExtentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new UsdAttribute CreateExtentAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateExtentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new UsdAttribute CreateExtentAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCapsule_CreateExtentAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public static bool ComputeExtent(double height, double radius, TfToken axis, VtVec3fArray extent)
        {
            bool ret = UsdCsPINVOKE.UsdGeomCapsule_ComputeExtent__SWIG_0(height, radius, TfToken.getCPtr(axis), VtVec3fArray.getCPtr(extent));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool ComputeExtent(double height, double radius, TfToken axis, GfMatrix4d transform, VtVec3fArray extent)
        {
            bool ret = UsdCsPINVOKE.UsdGeomCapsule_ComputeExtent__SWIG_1(height, radius, TfToken.getCPtr(axis), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }
}
