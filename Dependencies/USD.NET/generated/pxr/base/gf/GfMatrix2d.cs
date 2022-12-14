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
    public class GfMatrix2d : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal GfMatrix2d(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfMatrix2d obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~GfMatrix2d()
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
                        UsdCsPINVOKE.delete_GfMatrix2d(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public GfMatrix2d() : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_0(), true)
        {
        }

        public GfMatrix2d(double m00, double m01, double m10, double m11) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_1(m00, m01, m10, m11), true)
        {
        }

        public GfMatrix2d(double s) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_2(s), true)
        {
        }

        public GfMatrix2d(int s) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_3(s), true)
        {
        }

        public GfMatrix2d(GfVec2d v) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_4(GfVec2d.getCPtr(v)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfMatrix2d(StdDoubleVectorVector v) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_5(StdDoubleVectorVector.getCPtr(v)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfMatrix2d(StdFloatVectorVector v) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_6(StdFloatVectorVector.getCPtr(v)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfMatrix2d(GfMatrix2f m) : this(UsdCsPINVOKE.new_GfMatrix2d__SWIG_7(GfMatrix2f.getCPtr(m)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRow(int i, GfVec2d v)
        {
            UsdCsPINVOKE.GfMatrix2d_SetRow(swigCPtr, i, GfVec2d.getCPtr(v));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetColumn(int i, GfVec2d v)
        {
            UsdCsPINVOKE.GfMatrix2d_SetColumn(swigCPtr, i, GfVec2d.getCPtr(v));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public GfVec2d GetRow(int i)
        {
            GfVec2d ret = new GfVec2d(UsdCsPINVOKE.GfMatrix2d_GetRow(swigCPtr, i), true);
            return ret;
        }

        public GfVec2d GetColumn(int i)
        {
            GfVec2d ret = new GfVec2d(UsdCsPINVOKE.GfMatrix2d_GetColumn(swigCPtr, i), true);
            return ret;
        }

        public GfMatrix2d Set(double m00, double m01, double m10, double m11)
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_Set(swigCPtr, m00, m01, m10, m11), false);
            return ret;
        }

        public GfMatrix2d SetIdentity()
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_SetIdentity(swigCPtr), false);
            return ret;
        }

        public GfMatrix2d SetZero()
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_SetZero(swigCPtr), false);
            return ret;
        }

        public GfMatrix2d SetDiagonal(double s)
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_SetDiagonal__SWIG_0(swigCPtr, s), false);
            return ret;
        }

        public GfMatrix2d SetDiagonal(GfVec2d arg0)
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_SetDiagonal__SWIG_1(swigCPtr, GfVec2d.getCPtr(arg0)), false);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SWIGTYPE_p_double Get(SWIGTYPE_p_a_2__double m)
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.GfMatrix2d_Get(swigCPtr, SWIGTYPE_p_a_2__double.getCPtr(m));
            SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
            return ret;
        }

        public SWIGTYPE_p_double data()
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.GfMatrix2d_data(swigCPtr);
            SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
            return ret;
        }

        public GfMatrix2d GetTranspose()
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_GetTranspose(swigCPtr), true);
            return ret;
        }

        public GfMatrix2d GetInverse(ref double det, double eps)
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_GetInverse__SWIG_0(swigCPtr, ref det, eps), true);
            return ret;
        }

        public GfMatrix2d GetInverse(ref double det)
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_GetInverse__SWIG_1(swigCPtr, ref det), true);
            return ret;
        }

        public GfMatrix2d GetInverse()
        {
            GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.GfMatrix2d_GetInverse__SWIG_2(swigCPtr), true);
            return ret;
        }

        public double GetDeterminant()
        {
            double ret = UsdCsPINVOKE.GfMatrix2d_GetDeterminant(swigCPtr);
            return ret;
        }

        public static bool Equals(GfMatrix2d lhs, GfMatrix2d rhs)
        {
            bool ret = UsdCsPINVOKE.GfMatrix2d_Equals(GfMatrix2d.getCPtr(lhs), GfMatrix2d.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        override public int GetHashCode()
        {
            int ret = UsdCsPINVOKE.GfMatrix2d_GetHashCode(swigCPtr);
            return ret;
        }

        public static bool operator==(GfMatrix2d lhs, GfMatrix2d rhs)
        {
            // The Swig binding glue will re-enter this operator comparing to null, so
            // that case must be handled explicitly to avoid an infinite loop. This is still
            // not great, since it crosses the C#/C++ barrier twice. A better approache might
            // be to return a simple value from C++ that can be compared in C#.
            bool lnull = lhs as object == null;
            bool rnull = rhs as object == null;
            return (lnull == rnull) && ((lnull && rnull) || GfMatrix2d.Equals(lhs, rhs));
        }

        public static bool operator!=(GfMatrix2d lhs, GfMatrix2d rhs)
        {
            return !(lhs == rhs);
        }

        override public bool Equals(object rhs)
        {
            return GfMatrix2d.Equals(this, rhs as GfMatrix2d);
        }

        public override string ToString()
        {
            string ret = UsdCsPINVOKE.GfMatrix2d_ToString(swigCPtr);
            return ret;
        }

        public void CopyToArray(double[] dest)
        {
            UsdCsPINVOKE.GfMatrix2d_CopyToArray(swigCPtr, dest);
        }

        public void CopyFromArray(double[] src)
        {
            UsdCsPINVOKE.GfMatrix2d_CopyFromArray(swigCPtr, src);
        }

        public static readonly uint numRows = UsdCsPINVOKE.GfMatrix2d_numRows_get();
        public static readonly uint numColumns = UsdCsPINVOKE.GfMatrix2d_numColumns_get();
    }
}
