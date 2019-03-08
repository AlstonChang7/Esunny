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

public class TapAPIAccountRentInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountRentInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountRentInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccountRentInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPIAccountRentInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public char FeeMode {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_FeeMode_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_FeeMode_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenTurnover {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_OpenTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_OpenTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosedTurnover {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ClosedTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ClosedTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseNewTurnover {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CloseNewTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CloseNewTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenVolume {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_OpenVolume_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosedVolume {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ClosedVolume_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_ClosedVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseNewVolume {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CloseNewVolume_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_CloseNewVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginMode {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_MarginMode_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_MarginMode_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyTInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyTInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyTInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellTInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellTInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellTInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyBInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyBInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyBInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellBInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellBInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellBInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyLInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyLInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyLInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellLInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellLInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellLInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyMInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyMInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyMInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellMInitMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellMInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellMInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyTMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyTMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyTMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellTMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellTMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellTMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyBMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyBMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyBMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellBMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellBMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellBMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyLMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyLMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyLMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellLMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellLMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellLMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyMMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyMMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_BuyMMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellMMaintMargin {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellMMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPIAccountRentInfo_SellMMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountRentInfo() : this(QTapTradeApiPINVOKE.new_TapAPIAccountRentInfo(), true) {
  }

}

}