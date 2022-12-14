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
    public class GfVec3f : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal GfVec3f(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfVec3f obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~GfVec3f()
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
                        UsdCsPINVOKE.delete_GfVec3f(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public GfVec3f() : this(UsdCsPINVOKE.new_GfVec3f__SWIG_0(), true)
        {
        }

        public GfVec3f(float value) : this(UsdCsPINVOKE.new_GfVec3f__SWIG_1(value), true)
        {
        }

        public GfVec3f(float s0, float s1, float s2) : this(UsdCsPINVOKE.new_GfVec3f__SWIG_2(s0, s1, s2), true)
        {
        }

        public GfVec3f(GfVec3d other) : this(UsdCsPINVOKE.new_GfVec3f__SWIG_4(GfVec3d.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfVec3f(GfVec3h other) : this(UsdCsPINVOKE.new_GfVec3f__SWIG_5(GfVec3h.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfVec3f(GfVec3i other) : this(UsdCsPINVOKE.new_GfVec3f__SWIG_6(GfVec3i.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static GfVec3f XAxis()
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_XAxis(), true);
            return ret;
        }

        public static GfVec3f YAxis()
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_YAxis(), true);
            return ret;
        }

        public static GfVec3f ZAxis()
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_ZAxis(), true);
            return ret;
        }

        public static GfVec3f Axis(uint i)
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_Axis(i), true);
            return ret;
        }

        public GfVec3f Set(float s0, float s1, float s2)
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_Set(swigCPtr, s0, s1, s2), false);
            return ret;
        }

        public GfVec3f GetProjection(GfVec3f v)
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_GetProjection(swigCPtr, GfVec3f.getCPtr(v)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfVec3f GetComplement(GfVec3f b)
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_GetComplement(swigCPtr, GfVec3f.getCPtr(b)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public float GetLengthSq()
        {
            float ret = UsdCsPINVOKE.GfVec3f_GetLengthSq(swigCPtr);
            return ret;
        }

        public float GetLength()
        {
            float ret = UsdCsPINVOKE.GfVec3f_GetLength(swigCPtr);
            return ret;
        }

        public float Normalize(float eps)
        {
            float ret = UsdCsPINVOKE.GfVec3f_Normalize__SWIG_0(swigCPtr, eps);
            return ret;
        }

        public float Normalize()
        {
            float ret = UsdCsPINVOKE.GfVec3f_Normalize__SWIG_1(swigCPtr);
            return ret;
        }

        public GfVec3f GetNormalized(float eps)
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_GetNormalized__SWIG_0(swigCPtr, eps), true);
            return ret;
        }

        public GfVec3f GetNormalized()
        {
            GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfVec3f_GetNormalized__SWIG_1(swigCPtr), true);
            return ret;
        }

        public static bool OrthogonalizeBasis(GfVec3f tx, GfVec3f ty, GfVec3f tz, bool normalize, double eps)
        {
            bool ret = UsdCsPINVOKE.GfVec3f_OrthogonalizeBasis__SWIG_0(GfVec3f.getCPtr(tx), GfVec3f.getCPtr(ty), GfVec3f.getCPtr(tz), normalize, eps);
            return ret;
        }

        public static bool OrthogonalizeBasis(GfVec3f tx, GfVec3f ty, GfVec3f tz, bool normalize)
        {
            bool ret = UsdCsPINVOKE.GfVec3f_OrthogonalizeBasis__SWIG_1(GfVec3f.getCPtr(tx), GfVec3f.getCPtr(ty), GfVec3f.getCPtr(tz), normalize);
            return ret;
        }

        public void BuildOrthonormalFrame(GfVec3f v1, GfVec3f v2, float eps)
        {
            UsdCsPINVOKE.GfVec3f_BuildOrthonormalFrame__SWIG_0(swigCPtr, GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2), eps);
        }

        public void BuildOrthonormalFrame(GfVec3f v1, GfVec3f v2)
        {
            UsdCsPINVOKE.GfVec3f_BuildOrthonormalFrame__SWIG_1(swigCPtr, GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2));
        }

        public static bool Equals(GfVec3f lhs, GfVec3f rhs)
        {
            bool ret = UsdCsPINVOKE.GfVec3f_Equals(GfVec3f.getCPtr(lhs), GfVec3f.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        override public int GetHashCode()
        {
            int ret = UsdCsPINVOKE.GfVec3f_GetHashCode(swigCPtr);
            return ret;
        }

        public static bool operator==(GfVec3f lhs, GfVec3f rhs)
        {
            // The Swig binding glue will re-enter this operator comparing to null, so
            // that case must be handled explicitly to avoid an infinite loop. This is still
            // not great, since it crosses the C#/C++ barrier twice. A better approache might
            // be to return a simple value from C++ that can be compared in C#.
            bool lnull = lhs as object == null;
            bool rnull = rhs as object == null;
            return (lnull == rnull) && ((lnull && rnull) || GfVec3f.Equals(lhs, rhs));
        }

        public static bool operator!=(GfVec3f lhs, GfVec3f rhs)
        {
            return !(lhs == rhs);
        }

        override public bool Equals(object rhs)
        {
            return GfVec3f.Equals(this, rhs as GfVec3f);
        }

        protected float GetValue(int index)
        {
            float ret = UsdCsPINVOKE.GfVec3f_GetValue(swigCPtr, index);
            return ret;
        }

        protected void SetValue(int index, float value)
        {
            UsdCsPINVOKE.GfVec3f_SetValue(swigCPtr, index, value);
        }

        public float this[int index]
        {
            get { return GetValue(index); }
            set { SetValue(index, value); }
        }

        public static readonly uint dimension = UsdCsPINVOKE.GfVec3f_dimension_get();
    }
}
