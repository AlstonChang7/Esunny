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
    /// 资金账号资金信息
    /// </summary>
    public class TapAPIFundData : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIFundData(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFundData obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIFundData()
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
                        QTapTradeApiPINVOKE.delete_TapAPIFundData(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 客户资金账号
        /// </summary>
        public string AccountNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPIFundData_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上级资金账号
        /// </summary>
        public string ParentAccountNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_ParentAccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPIFundData_ParentAccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 币种组号
        /// </summary>
        public string CurrencyGroupNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CurrencyGroupNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPIFundData_CurrencyGroupNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 币种号(为空表示币种组基币资金)
        /// </summary>
        public string CurrencyNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CurrencyNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPIFundData_CurrencyNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 交易汇率
        /// </summary>
        public double TradeRate
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_TradeRate_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_TradeRate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 期货算法
        /// </summary>
        public char FutureAlg
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_FutureAlg_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPIFundData_FutureAlg_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 期权算法
        /// </summary>
        public char OptionAlg
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_OptionAlg_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPIFundData_OptionAlg_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日结存
        /// </summary>
        public double PreBalance
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PreBalance_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PreBalance_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日未到期平盈
        /// </summary>
        public double PreUnExpProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PreUnExpProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PreUnExpProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日LME持仓平盈
        /// </summary>
        public double PreLMEPositionProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PreLMEPositionProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PreLMEPositionProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日权益
        /// </summary>
        public double PreEquity
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PreEquity_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PreEquity_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日可用
        /// </summary>
        public double PreAvailable1
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PreAvailable1_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PreAvailable1_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日市值权益
        /// </summary>
        public double PreMarketEquity
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PreMarketEquity_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PreMarketEquity_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 入金
        /// </summary>
        public double CashInValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CashInValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_CashInValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 出金
        /// </summary>
        public double CashOutValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CashOutValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_CashOutValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 资金调整
        /// </summary>
        public double CashAdjustValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CashAdjustValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_CashAdjustValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 质押资金
        /// </summary>
        public double CashPledged
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CashPledged_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_CashPledged_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 冻结手续费
        /// </summary>
        public double FrozenFee
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_FrozenFee_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_FrozenFee_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 冻结保证金
        /// </summary>
        public double FrozenDeposit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_FrozenDeposit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_FrozenDeposit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 客户手续费包含交割手续费
        /// </summary>
        public double AccountFee
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_AccountFee_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_AccountFee_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 汇兑手续费
        /// </summary>
        public double ExchangeFee
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_ExchangeFee_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_ExchangeFee_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 客户交割手续费
        /// </summary>
        public double AccountDeliveryFee
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_AccountDeliveryFee_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_AccountDeliveryFee_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 权利金收取
        /// </summary>
        public double PremiumIncome
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PremiumIncome_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PremiumIncome_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 权利金支付
        /// </summary>
        public double PremiumPay
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PremiumPay_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PremiumPay_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CloseProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_CloseProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 交割盈亏
        /// </summary>
        public double DeliveryProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_DeliveryProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_DeliveryProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 未到期平盈
        /// </summary>
        public double UnExpProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_UnExpProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_UnExpProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 到期平仓盈亏
        /// </summary>
        public double ExpProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_ExpProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_ExpProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 不含LME持仓盈亏
        /// </summary>
        public double PositionProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PositionProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PositionProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// LME持仓盈亏
        /// </summary>
        public double LmePositionProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_LmePositionProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_LmePositionProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 期权市值
        /// </summary>
        public double OptionMarketValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_OptionMarketValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_OptionMarketValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 客户初始保证金
        /// </summary>
        public double AccountIntialMargin
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_AccountIntialMargin_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_AccountIntialMargin_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 客户维持保证金
        /// </summary>
        public double AccountMaintenanceMargin
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_AccountMaintenanceMargin_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_AccountMaintenanceMargin_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上手初始保证金
        /// </summary>
        public double UpperInitalMargin
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_UpperInitalMargin_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_UpperInitalMargin_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上手维持保证金
        /// </summary>
        public double UpperMaintenanceMargin
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_UpperMaintenanceMargin_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_UpperMaintenanceMargin_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// LME贴现
        /// </summary>
        public double Discount
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_Discount_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_Discount_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 当日结存
        /// </summary>
        public double Balance
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_Balance_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_Balance_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 当日权益
        /// </summary>
        public double Equity
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_Equity_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_Equity_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 当日可用
        /// </summary>
        public double Available
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_Available_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_Available_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 可提取
        /// </summary>
        public double CanDraw
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_CanDraw_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_CanDraw_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 账户市值
        /// </summary>
        public double MarketEquity
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_MarketEquity_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_MarketEquity_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 币种原始出入金
        /// </summary>
        public double OriginalCashInOut
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_OriginalCashInOut_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_OriginalCashInOut_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 逐笔浮盈
        /// </summary>
        public double FloatingPL
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_FloatingPL_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_FloatingPL_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 风险冻结资金
        /// </summary>
        public double FrozenRiskFundValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_FrozenRiskFundValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_FrozenRiskFundValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 逐笔平盈
        /// </summary>
        public double ClosePL
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_ClosePL_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_ClosePL_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 非货币质押
        /// </summary>
        public double NoCurrencyPledgeValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_NoCurrencyPledgeValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_NoCurrencyPledgeValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 期初质押
        /// </summary>
        public double PrePledgeValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PrePledgeValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PrePledgeValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 质入
        /// </summary>
        public double PledgeIn
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PledgeIn_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PledgeIn_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 质出
        /// </summary>
        public double PledgeOut
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PledgeOut_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PledgeOut_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 质押余额
        /// </summary>
        public double PledgeValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_PledgeValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_PledgeValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 借用金额
        /// </summary>
        public double BorrowValue
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_BorrowValue_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_BorrowValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品冻结保证金
        /// </summary>
        public double SpecialAccountFrozenMargin
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountFrozenMargin_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountFrozenMargin_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品保证金 
        /// </summary>
        public double SpecialAccountMargin
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountMargin_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountMargin_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品冻结手续费
        /// </summary>
        public double SpecialAccountFrozenFee
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountFrozenFee_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountFrozenFee_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品手续费
        /// </summary>
        public double SpecialAccountFee
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountFee_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialAccountFee_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品浮盈
        /// </summary>
        public double SpecialFloatProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialFloatProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialFloatProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品平盈
        /// </summary>
        public double SpecialCloseProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialCloseProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialCloseProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品逐笔浮盈
        /// </summary>
        public double SpecialFloatPL
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialFloatPL_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialFloatPL_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 特殊产品逐笔平盈
        /// </summary>
        public double SpecialClosePL
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPIFundData_SpecialClosePL_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPIFundData_SpecialClosePL_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIFundData() : this(QTapTradeApiPINVOKE.new_TapAPIFundData(), true)
        {
        }

    }

}
