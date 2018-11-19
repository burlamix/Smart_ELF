//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IPWMControl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IPWMControl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IPWMControl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IPWMControl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IPWMControl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getNumberOfMotors(SWIGTYPE_p_int number) {
    bool ret = yarpPINVOKE.IPWMControl_getNumberOfMotors(swigCPtr, SWIGTYPE_p_int.getCPtr(number));
    return ret;
  }

  public virtual bool setRefDutyCycle(int m, double arg1) {
    bool ret = yarpPINVOKE.IPWMControl_setRefDutyCycle(swigCPtr, m, arg1);
    return ret;
  }

  public virtual bool setRefDutyCycles(SWIGTYPE_p_double refs) {
    bool ret = yarpPINVOKE.IPWMControl_setRefDutyCycles(swigCPtr, SWIGTYPE_p_double.getCPtr(refs));
    return ret;
  }

  public virtual bool getRefDutyCycle(int m, SWIGTYPE_p_double arg1) {
    bool ret = yarpPINVOKE.IPWMControl_getRefDutyCycle(swigCPtr, m, SWIGTYPE_p_double.getCPtr(arg1));
    return ret;
  }

  public virtual bool getRefDutyCycles(SWIGTYPE_p_double refs) {
    bool ret = yarpPINVOKE.IPWMControl_getRefDutyCycles(swigCPtr, SWIGTYPE_p_double.getCPtr(refs));
    return ret;
  }

  public virtual bool getDutyCycle(int m, SWIGTYPE_p_double val) {
    bool ret = yarpPINVOKE.IPWMControl_getDutyCycle(swigCPtr, m, SWIGTYPE_p_double.getCPtr(val));
    return ret;
  }

  public virtual bool getDutyCycles(SWIGTYPE_p_double vals) {
    bool ret = yarpPINVOKE.IPWMControl_getDutyCycles(swigCPtr, SWIGTYPE_p_double.getCPtr(vals));
    return ret;
  }

}