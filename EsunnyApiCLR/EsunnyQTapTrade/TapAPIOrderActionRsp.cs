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
    /// 报单操作应答结构
    /// </summary>
    public class TapAPIOrderActionRsp : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIOrderActionRsp(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderActionRsp obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIOrderActionRsp()
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
                        QTapTradeApiPINVOKE.delete_TapAPIOrderActionRsp(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 操作类型
        /// </summary>
        public char ActionType
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIOrderActionRsp_ActionType_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPIOrderActionRsp_ActionType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托信息
        /// </summary>
        public TapAPIOrderInfo OrderInfo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIOrderActionRsp_OrderInfo_set(swigCPtr, TapAPIOrderInfo.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = QTapTradeApiPINVOKE.TapAPIOrderActionRsp_OrderInfo_get(swigCPtr);
                TapAPIOrderInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIOrderInfo(cPtr, false);
                return ret;
            }
        }

        public TapAPIOrderActionRsp() : this(QTapTradeApiPINVOKE.new_TapAPIOrderActionRsp(), true)
        {
        }

    }

}
