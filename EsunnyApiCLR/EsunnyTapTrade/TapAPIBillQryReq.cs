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

public class TapAPIBillQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIBillQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIBillQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIBillQryReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIBillQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIBillQryReq_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIBillQryReq_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public char BillType {
    set {
      TapTradeWrapperPINVOKE.TapAPIBillQryReq_BillType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIBillQryReq_BillType_get(swigCPtr);
      return ret;
    } 
  }

  public string BillDate {
    set {
      TapTradeWrapperPINVOKE.TapAPIBillQryReq_BillDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIBillQryReq_BillDate_get(swigCPtr);
      return ret;
    } 
  }

  public char BillFileType {
    set {
      TapTradeWrapperPINVOKE.TapAPIBillQryReq_BillFileType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIBillQryReq_BillFileType_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIBillQryReq() : this(TapTradeWrapperPINVOKE.new_TapAPIBillQryReq(), true) {
  }

}

}