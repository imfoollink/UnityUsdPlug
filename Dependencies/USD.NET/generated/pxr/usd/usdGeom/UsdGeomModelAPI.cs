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
    public class UsdGeomModelAPI : UsdAPISchemaBase
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdGeomModelAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomModelAPI_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomModelAPI obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdGeomModelAPI()
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
                        UsdCsPINVOKE.delete_UsdGeomModelAPI(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdGeomModelAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomModelAPI__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdGeomModelAPI() : this(UsdCsPINVOKE.new_UsdGeomModelAPI__SWIG_1(), true)
        {
        }

        public UsdGeomModelAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdGeomModelAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public static UsdGeomModelAPI Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdGeomModelAPI ret = new UsdGeomModelAPI(UsdCsPINVOKE.UsdGeomModelAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static UsdGeomModelAPI Apply(UsdPrim prim)
        {
            UsdGeomModelAPI ret = new UsdGeomModelAPI(UsdCsPINVOKE.UsdGeomModelAPI_Apply(UsdPrim.getCPtr(prim)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetModelDrawModeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelDrawModeAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelDrawModeAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelDrawModeAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelDrawModeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelApplyDrawModeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelApplyDrawModeAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelApplyDrawModeAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelApplyDrawModeAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelApplyDrawModeAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelDrawModeColorAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelDrawModeColorAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelDrawModeColorAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelDrawModeColorAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelDrawModeColorAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardGeometryAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardGeometryAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardGeometryAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardGeometryAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardGeometryAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardTextureXPosAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardTextureXPosAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardTextureXPosAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureXPosAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureXPosAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardTextureYPosAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardTextureYPosAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardTextureYPosAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureYPosAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureYPosAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardTextureZPosAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardTextureZPosAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardTextureZPosAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureZPosAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureZPosAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardTextureXNegAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardTextureXNegAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardTextureXNegAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureXNegAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureXNegAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardTextureYNegAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardTextureYNegAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardTextureYNegAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureYNegAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureYNegAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetModelCardTextureZNegAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetModelCardTextureZNegAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateModelCardTextureZNegAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureZNegAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateModelCardTextureZNegAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public bool GetExtentsHint(VtVec3fArray extents, UsdTimeCode time)
        {
            bool ret = UsdCsPINVOKE.UsdGeomModelAPI_GetExtentsHint__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(extents), UsdTimeCode.getCPtr(time));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool GetExtentsHint(VtVec3fArray extents)
        {
            bool ret = UsdCsPINVOKE.UsdGeomModelAPI_GetExtentsHint__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(extents));
            return ret;
        }

        public bool SetExtentsHint(VtVec3fArray extents, UsdTimeCode time)
        {
            bool ret = UsdCsPINVOKE.UsdGeomModelAPI_SetExtentsHint__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(extents), UsdTimeCode.getCPtr(time));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetExtentsHint(VtVec3fArray extents)
        {
            bool ret = UsdCsPINVOKE.UsdGeomModelAPI_SetExtentsHint__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(extents));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetExtentsHintAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomModelAPI_GetExtentsHintAttr(swigCPtr), true);
            return ret;
        }

        public VtVec3fArray ComputeExtentsHint(UsdGeomBBoxCache bboxCache)
        {
            VtVec3fArray ret = new VtVec3fArray(UsdCsPINVOKE.UsdGeomModelAPI_ComputeExtentsHint(swigCPtr, UsdGeomBBoxCache.getCPtr(bboxCache)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdGeomConstraintTarget GetConstraintTarget(string constraintName)
        {
            UsdGeomConstraintTarget ret = new UsdGeomConstraintTarget(UsdCsPINVOKE.UsdGeomModelAPI_GetConstraintTarget(swigCPtr, constraintName), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdGeomConstraintTarget CreateConstraintTarget(string constraintName)
        {
            UsdGeomConstraintTarget ret = new UsdGeomConstraintTarget(UsdCsPINVOKE.UsdGeomModelAPI_CreateConstraintTarget(swigCPtr, constraintName), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdGeomConstraintTargetVector GetConstraintTargets()
        {
            UsdGeomConstraintTargetVector ret = new UsdGeomConstraintTargetVector(UsdCsPINVOKE.UsdGeomModelAPI_GetConstraintTargets(swigCPtr), true);
            return ret;
        }

        public TfToken ComputeModelDrawMode(TfToken parentDrawMode)
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomModelAPI_ComputeModelDrawMode__SWIG_0(swigCPtr, TfToken.getCPtr(parentDrawMode)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public TfToken ComputeModelDrawMode()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomModelAPI_ComputeModelDrawMode__SWIG_1(swigCPtr), true);
            return ret;
        }
    }
}
