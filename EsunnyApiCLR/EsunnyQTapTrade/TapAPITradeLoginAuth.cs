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
    /// 登录认证信息
    /// </summary>
    public class TapAPITradeLoginAuth : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPITradeLoginAuth(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginAuth obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPITradeLoginAuth()
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
                        QTapTradeApiPINVOKE.delete_TapAPITradeLoginAuth(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_UserNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_UserNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 是否修改密码
        /// </summary>
        public char ISModifyPassword
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_Password_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_Password_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_NewPassword_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_NewPassword_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 是否需要动态认证
        /// </summary>
        public char ISDDA
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_ISDDA_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_ISDDA_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 动态认证码
        /// </summary>
        public string DDASerialNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_DDASerialNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_DDASerialNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 忽略推送通知标记
        /// </summary>
        public uint NoticeIgnoreFlag
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPITradeLoginAuth_NoticeIgnoreFlag_set(swigCPtr, value);
            }
            get
            {
                uint ret = QTapTradeApiPINVOKE.TapAPITradeLoginAuth_NoticeIgnoreFlag_get(swigCPtr);
                return ret;
            }
        }

        public TapAPITradeLoginAuth() : this(QTapTradeApiPINVOKE.new_TapAPITradeLoginAuth(), true)
        {
        }

    }

}
