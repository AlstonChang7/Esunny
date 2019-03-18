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
    /// 品种编码结构
    /// </summary>
    public class TapAPICommodity : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPICommodity(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICommodity obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPICommodity()
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
                        QTapTradeApiPINVOKE.delete_TapAPICommodity(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 交易所编码
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICommodity_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICommodity_ExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 品种类型
        /// </summary>
        public char CommodityType
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICommodity_CommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICommodity_CommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 品种编号
        /// </summary>
        public string CommodityNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICommodity_CommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICommodity_CommodityNo_get(swigCPtr);
                return ret;
            }
        }

        public TapAPICommodity() : this(QTapTradeApiPINVOKE.new_TapAPICommodity(), true)
        {
        }

    }

}
