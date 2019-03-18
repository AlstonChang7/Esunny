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

public class TapAPIHisPositionQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisPositionQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIHisPositionQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisPositionQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIHisPositionQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string SettleDate {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionPrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionQty {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string PositionNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroup {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_CurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string Currency {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_Currency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_Currency_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_SettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_SettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionDProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionDProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionDProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LMEPositionProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_LMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_LMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountInitialMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMaintenanceMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperInitialMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMaintenanceMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public string SettleGroupNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisPositionQryRsp() : this(TapTradeWrapperPINVOKE.new_TapAPIHisPositionQryRsp(), true) {
  }

}

}