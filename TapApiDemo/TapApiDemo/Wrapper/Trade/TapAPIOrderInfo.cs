//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi {

public class TapAPIOrderInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPIOrderInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_PositionEffect2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_PositionEffect2_get(swigCPtr);
      return ret;
    } 
  }

  public string InquiryNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_InquiryNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_InquiryNo_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMinQty {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMinQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMinQty_get(swigCPtr);
      return ret;
    } 
  }

  public int RefInt {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public double RefDouble {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_RefDouble_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_RefDouble_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public uint MinClipSize {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_MinClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_MinClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint MaxClipSize {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_MaxClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_MaxClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public string LicenseNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_LicenseNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_LicenseNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientOrderNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientOrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientOrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public char TacticsType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TacticsType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TacticsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerCondition {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TriggerCondition_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TriggerCondition_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerPriceType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TriggerPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_TriggerPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char AddOneIsValid {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_AddOneIsValid_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_AddOneIsValid_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientLocalIP {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientLocalIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientLocalIP_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientMac {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientMac_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientMac_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientIP {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ClientIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderStreamID {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderLocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderLocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint UpperStreamID {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_UpperStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_UpperStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSystemNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeSystemNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderExchangeSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderExchangeSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderParentSystemNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderParentSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderParentSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderInsertUserNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderInsertUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderInsertUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderInsertTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderInsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderInsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommandUserNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderCommandUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderCommandUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderUpdateUserNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderUpdateUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderUpdateUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderUpdateTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderUpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderUpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderState {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderState_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchQty2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_OrderMatchQty2_get(swigCPtr);
      return ret;
    } 
  }

  public uint ErrorCode {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ErrorCode_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ErrorCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorText {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ErrorText_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_ErrorText_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDeleted {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsDeleted_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsDeleted_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderInfo_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderInfo() : this(TapTradeWrapperAPIPINVOKE.new_TapAPIOrderInfo(), true) {
  }

}

}