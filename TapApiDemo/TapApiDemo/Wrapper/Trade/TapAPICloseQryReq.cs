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

public class TapAPICloseQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPICloseQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICloseQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPICloseQryReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPICloseQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPICloseQryReq_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICloseQryReq() : this(TapTradeWrapperAPIPINVOKE.new_TapAPICloseQryReq(), true) {
  }

}

}