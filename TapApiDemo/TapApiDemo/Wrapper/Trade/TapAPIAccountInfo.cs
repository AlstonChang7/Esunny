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

public class TapAPIAccountInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccountInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIAccountInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountType {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountType_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountState {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountState_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountTradeRight {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountTradeRight_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountTradeRight_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityGroupNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_CommodityGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_CommodityGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountShortName {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountShortName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountShortName_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountEnShortName {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountEnShortName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountInfo_AccountEnShortName_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountInfo() : this(TapTradeWrapperPINVOKE.new_TapAPIAccountInfo(), true) {
  }

}

}
