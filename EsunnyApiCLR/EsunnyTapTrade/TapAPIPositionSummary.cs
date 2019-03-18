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

public class TapAPIPositionSummary : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIPositionSummary(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIPositionSummary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIPositionSummary() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIPositionSummary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionPrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_PositionPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_PositionPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionQty {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_PositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_PositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint HisPositionQty {
    set {
      TapTradeWrapperPINVOKE.TapAPIPositionSummary_HisPositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperPINVOKE.TapAPIPositionSummary_HisPositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIPositionSummary() : this(TapTradeWrapperPINVOKE.new_TapAPIPositionSummary(), true) {
  }

}

}