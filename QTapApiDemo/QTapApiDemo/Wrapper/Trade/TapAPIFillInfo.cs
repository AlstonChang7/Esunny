//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapTradeWrapperApi {

public class TapAPIFillInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIFillInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFillInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIFillInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPIFillInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ParentAccountNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ParentAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ParentAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNoRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ExchangeNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ExchangeNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityTypeRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityTypeRef_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityTypeRef_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNoRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNoRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ContractNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ContractNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePriceRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_StrikePriceRef_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_StrikePriceRef_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlagRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CallOrPutFlagRef_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CallOrPutFlagRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OrderExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OrderExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderCommodityType {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OrderCommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OrderCommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommodityNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OrderCommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OrderCommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffectRef {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_PositionEffectRef_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_PositionEffectRef_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OrderLocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OrderLocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeMatchNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ExchangeMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ExchangeMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchDateTime {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperMatchDateTime {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperMatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperMatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperSettleNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperSettleNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperSettleNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperUserNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_TradeNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_TradeNo_get(swigCPtr);
      return ret;
    } 
  }

  public double MatchPrice {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchQty {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDeleted {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_IsDeleted_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_IsDeleted_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchStreamID {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_MatchStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPIFillInfo_MatchStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public uint UpperStreamID {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenCloseMode {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OpenCloseMode_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OpenCloseMode_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroup {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public char FeeMode {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_FeeMode_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_FeeMode_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeParam {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_FeeParam_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_FeeParam_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrencyGroup {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_FeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_FeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrency {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_FeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_FeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeValue {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_FeeValue_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_FeeValue_get(swigCPtr);
      return ret;
    } 
  }

  public char IsManualFee {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_IsManualFee_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIFillInfo_IsManualFee_get(swigCPtr);
      return ret;
    } 
  }

  public double Turnover {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_Turnover_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_Turnover_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumIncome {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_PremiumIncome_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_PremiumIncome_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumPay {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_PremiumPay_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_PremiumPay_get(swigCPtr);
      return ret;
    } 
  }

  public string OppoMatchNo {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_OppoMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIFillInfo_OppoMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double UnExpProfit {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMatchPrice {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_UpperMatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_UpperMatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QuotePrice {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_QuotePrice_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_QuotePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePL {
    set {
      QTapTradeApiPINVOKE.TapAPIFillInfo_ClosePL_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIFillInfo_ClosePL_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIFillInfo() : this(QTapTradeApiPINVOKE.new_TapAPIFillInfo(), true) {
  }

}

}
