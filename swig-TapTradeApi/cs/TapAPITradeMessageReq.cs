//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperAPI {

public class TapAPITradeMessageReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeMessageReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeMessageReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPITradeMessageReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPITradeMessageReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountAttributeNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_AccountAttributeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_AccountAttributeNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BenginSendDateTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_BenginSendDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_BenginSendDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string EndSendDateTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_EndSendDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeMessageReq_EndSendDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeMessageReq() : this(TapTradeWrapperAPIPINVOKE.new_TapAPITradeMessageReq(), true) {
  }

}

}