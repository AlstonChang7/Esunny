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
    /// TapTradeAPI 对外功能接口
    /// </summary>
    public class ITapTradeAPI : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ITapTradeAPI(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapTradeAPI obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~ITapTradeAPI()
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
                        QTapTradeApiPINVOKE.delete_ITapTradeAPI(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// 设置API的回调接口对象。系统对API的通知将通过设置的回调对象通知给使用者。ITapTradeAPINotify是API的回调接口，用户需要继承实现此接口类对象来完成用户需要的功能。
        /// 如果用户没有设置回调接口，则API不会向用户返回任何有用的信息。ITapTradeAPINotify类的详细内容请查看TapTradeAPI.h 文件。
        /// 同步操作
        /// </summary>
        /// <param name="apiNotify">实现了ITapTradeAPINotify接口的对象</param>
        /// <returns>0 登录成功，非0 错误码</returns>
        public virtual int SetAPINotify(ITapTradeAPINotify apiNotify)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_SetAPINotify(swigCPtr, ITapTradeAPINotify.getCPtr(apiNotify));
            return ret;
        }
        /// <summary>
        /// 设置服务器的IP地址和端口。同步操作
        /// </summary>
        /// <param name="IP">IP地址</param>
        /// <param name="port">端口号</param>
        /// <returns>0 登录成功，非0 错误码</returns>
        public virtual int SetHostAddress(string IP, ushort port)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_SetHostAddress(swigCPtr, IP, port);
            return ret;
        }
        /// <summary>
        /// 发起登录请求。API将先连接服务，建立链路，发起登录认证。在使用函数前用户需要完成服务器的设置SetHostAddress()，并且创建TapAPITradeLoginAuth类型的用户信息，
        /// 并且需要设置好回调接口。登录过程中建立连接的返回信息通过回调OnConnect返回给用户。连接建立后的用户验证回馈信息通过回调OnLogin()返回给用户。
        /// 登录成功后API会自动进行API的初始化，API向服务器请求基础数据，查询完以后会通过回调 OnAPIReady() 指示用户API初始化完成，可以进行后续的操作了。
        /// 异步操作 TapAPITradeLoginAuth中的NoticeIgnoreFlag用于标记是否忽略特定的通知回调。例如：不需要接收OnRtnFund和OnRtnPositionProfit,可以这么设定：
        /// NoticeIgnoreFlag = TAPI_NOTICE_IGNORE_FUND | TAPI_NOTICE_IGNORE_POSITIONPROFIT;Login()函数调用成功只是代表于服务器建立了链路连接，
        /// 只有回调OnLogin()的返回能指示用户是否成功登录了。
        /// </summary>
        /// <param name="loginAuth">包含登录需要的验证信息</param>
        /// <returns>0 登录成功，API开始准备后台数据 非0 错误码</returns>
        public virtual int Login(TapAPITradeLoginAuth loginAuth)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_Login(swigCPtr, TapAPITradeLoginAuth.getCPtr(loginAuth));
            return ret;
        }

        /// <summary>
        /// 断开和服务器的链路连接。调用函数后API将登出并断开与服务器的连接。同步操作
        /// </summary>
        /// <returns></returns>
        public virtual int Disconnect()
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_Disconnect(swigCPtr);
            return ret;
        }

        /// <summary>
        /// 修改密码。成功后用户密码将被设置成newPassword。异步操作
        /// </summary>
        /// <param name="sessionID">返回此次修改密码的会话ID;</param>
        /// <param name="req">请求修改密码的结构体</param>
        /// <returns>0 成功，非0 错误码</returns>
        public virtual int ChangePassword(out uint sessionID, TapAPIChangePasswordReq req)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_ChangePassword(swigCPtr, out sessionID, TapAPIChangePasswordReq.getCPtr(req));
            return ret;
        }
        /// <summary>
        /// 判断登录用户是否具有某权限。用户的权限在用户登录时已经传递给API，所以此函数执行的是本地的查询。同步操作
        /// </summary>
        /// <param name="rightID">权限ID。</param>
        /// <returns>0 不具有权限 非0 具有权限</returns>
        public virtual int HaveCertainRight(int rightID)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_HaveCertainRight(swigCPtr, rightID);
            return ret;
        }
        /// <summary>
        /// 设置用户预留信息。用户可以设置一个长度为50以内的字符信息，下次登录后可以得到这个信息。这个功能主要是用来让用户确认是自己的账号，主要是用来进行防伪。
        /// 异步操作 该接口暂未实现
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="info">预留信息字符串</param>
        /// <returns>0 成功，非0 错误码</returns>
        public virtual int SetReservedInfo(out uint sessionID, string info)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_SetReservedInfo(swigCPtr, out sessionID, info);
            return ret;
        }
        /// <summary>
        /// 查询用户下属的资金账号 TapAPIAccQryReq是包含资金账号结构的结构体，用户需要实例化此结构体，
        /// 但是不需要填写，这个结构体主要是用来提醒用户保存资金账号，资金账号在后续的函数调用中很多函数都需要使用到。
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询用户下属的资金账号的结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryAccount(out uint sessionID, TapAPIAccQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryAccount(swigCPtr, out sessionID, TapAPIAccQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询客户资金 TapAPIFundReq需要QryAccount()获取的资金账号。函数的回调将返回资金账号的资金信息。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询客户资金请求的结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryFund(out uint sessionID, TapAPIFundReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryFund(swigCPtr, out sessionID, TapAPIFundReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询交易系统交易所信息 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryExchange(out uint sessionID)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryExchange(swigCPtr, out sessionID);
            return ret;
        }
        /// <summary>
        /// 查询系统品种信息 函数请求获取所有的品种信息。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryCommodity(out uint sessionID)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryCommodity(swigCPtr, out sessionID);
            return ret;
        }
        /// <summary>
        /// 查询系统中指定品种的合约信息 使用此函数前需要先QrycommodityInfo()取得品种信息，然后选择需要的品种将信息填入TapAPICommodity结构体中完成查询请求。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询系统中指定品种的合约信息请求的结构体 该参数各字段为可选字段，可以用以下方法查询：1.全部留空：查所有合约；
        /// 2.仅交易所编码有效：查该交易所下所有品种的合约；3.交易所编码和品种类型有效：查该交易所下指定品种类型的合约；
        /// 4.交易所编码、品种类型和品种编码都有效：查该品种下的所有合约
        /// </param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryContract(out uint sessionID, TapAPICommodity qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryContract(swigCPtr, out sessionID, TapAPICommodity.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 下单 用户的下单操作会造成用户的资金、持仓、平仓、资金、风控标记等多种数据的变化，所以用户下的单成交后，会有多个回调通知来向用户展示数据的变化。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="order">新的委托</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int InsertOrder(out uint sessionID, TapAPINewOrder order)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_InsertOrder(swigCPtr, out sessionID, TapAPINewOrder.getCPtr(order));
            return ret;
        }
        /// <summary>
        /// 撤单 用户委托没有完全成交之前撤销剩余的委托。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="order">撤销的委托</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int CancelOrder(out uint sessionID, TapAPIOrderCancelReq order)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_CancelOrder(swigCPtr, out sessionID, TapAPIOrderCancelReq.getCPtr(order));
            return ret;
        }
        /// <summary>
        /// 查询委托信息 返回当前的委托信息，可以查询所有委托，也可以查询所有未结束的委托。异步操作
        /// 该接口可以多次调用，但是有查询频率的要求，每两秒可以查询一次
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">0 请求成功，非0 错误码</param>
        /// <returns></returns>
        public virtual int QryOrder(out uint sessionID, TapAPIOrderQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryOrder(swigCPtr, out sessionID, TapAPIOrderQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询委托变化流程 查询用户的委托的变化流程，查询将返回委托的每一次的变化。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">委托流程查询信息结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryOrderProcess(out uint sessionID, TapAPIOrderProcessQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryOrderProcess(swigCPtr, out sessionID, TapAPIOrderProcessQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询成交信息。每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnFill取得。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">成交查询信息结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryFill(out uint sessionID, TapAPIFillQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryFill(swigCPtr, out sessionID, TapAPIFillQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询用户持仓 该接口可以多次调用，但是有查询频率的要求，每两秒可以查询一次。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询用户持仓请求的结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryPosition(out uint sessionID, TapAPIPositionQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryPosition(swigCPtr, out sessionID, TapAPIPositionQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询平仓记录 每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnClose取得。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询平仓记录请求的结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryClose(out uint sessionID, TapAPICloseQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryClose(swigCPtr, out sessionID, TapAPICloseQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询深度行情 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询深度行情的请求结构体指针，第二个合约留空。</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryDeepQuote(out uint sessionID, TapAPIContract qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryDeepQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询交易所时间状态信息 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询交易所时间状态信息请求结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryExchangeStateInfo(out uint sessionID, TapAPIExchangeStateInfoQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryExchangeStateInfo(swigCPtr, out sessionID, TapAPIExchangeStateInfoQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询上手信息,主要是用于客户下单时指定通道号，方便主动选择单子进入交易所前置机 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">上手通道信息查询请求结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryUpperChannel(out uint sessionID, TapAPIUpperChannelQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryUpperChannel(swigCPtr, out sessionID, TapAPIUpperChannelQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 查询客户最终费率,主要是用于客户查询各个合约最终费率，可用于结算等 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">客户最终费率查询请求结构体</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int QryAccountRent(out uint sessionID, TapAPIAccountRentQryReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_QryAccountRent(swigCPtr, out sessionID, TapAPIAccountRentQryReq.getCPtr(qryReq));
            return ret;
        }
        /// <summary>
        /// 激活挂起的报单。委托将可以重新开始触发成交。
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">激活的委托</param>
        /// <returns>0 请求成功，非0 错误码</returns>
        public virtual int ActivateOrder(out uint sessionID, TapAPIOrderCancelReq qryReq)
        {
            int ret = QTapTradeApiPINVOKE.ITapTradeAPI_ActivateOrder(swigCPtr, out sessionID, TapAPIOrderCancelReq.getCPtr(qryReq));
            return ret;
        }

    }

}
