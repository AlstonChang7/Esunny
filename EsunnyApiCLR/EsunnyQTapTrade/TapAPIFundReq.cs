//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapTradeWrapperApi
{
    /// <summary>
    /// 资金查询请求
    /// </summary>
    public class TapAPIFundReq : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIFundReq(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFundReq obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIFundReq()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        QTapTradeApiPINVOKE.delete_TapAPIFundReq(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 客户资金帐号
        /// </summary>
        public string AccountNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundReq_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPIFundReq_AccountNo_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIFundReq() : this(QTapTradeApiPINVOKE.new_TapAPIFundReq(), true)
        {
        }

    }

}
