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
          QTapTradeApiPINVOKE.delete_TapAPIAccountInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountType {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountType_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountState {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountState_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountState_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountShortName {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountShortName_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountShortName_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountIsDocHolder {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountIsDocHolder_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountIsDocHolder_get(swigCPtr);
      return ret;
    } 
  }

  public char IsMarketMaker {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_IsMarketMaker_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_IsMarketMaker_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountFamilyType {
    set {
      QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountFamilyType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAccountInfo_AccountFamilyType_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountInfo() : this(QTapTradeApiPINVOKE.new_TapAPIAccountInfo(), true) {
  }

}

}
