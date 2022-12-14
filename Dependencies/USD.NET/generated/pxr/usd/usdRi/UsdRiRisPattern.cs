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
    public class UsdRiRisPattern : UsdRiRisObject
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdRiRisPattern(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiRisPattern_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiRisPattern obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdRiRisPattern()
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
                        UsdCsPINVOKE.delete_UsdRiRisPattern(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdRiRisPattern(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiRisPattern__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdRiRisPattern() : this(UsdCsPINVOKE.new_UsdRiRisPattern__SWIG_1(), true)
        {
        }

        public UsdRiRisPattern(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiRisPattern__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiRisPattern_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiRisPattern_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public new static UsdRiRisPattern Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiRisPattern ret = new UsdRiRisPattern(UsdCsPINVOKE.UsdRiRisPattern_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new static UsdRiRisPattern Define(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiRisPattern ret = new UsdRiRisPattern(UsdCsPINVOKE.UsdRiRisPattern_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }
}
