//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MotorTorqueParameters : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MotorTorqueParameters(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MotorTorqueParameters obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MotorTorqueParameters() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_MotorTorqueParameters(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double bemf {
    set {
      yarpPINVOKE.MotorTorqueParameters_bemf_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.MotorTorqueParameters_bemf_get(swigCPtr);
      return ret;
    } 
  }

  public double bemf_scale {
    set {
      yarpPINVOKE.MotorTorqueParameters_bemf_scale_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.MotorTorqueParameters_bemf_scale_get(swigCPtr);
      return ret;
    } 
  }

  public double ktau {
    set {
      yarpPINVOKE.MotorTorqueParameters_ktau_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.MotorTorqueParameters_ktau_get(swigCPtr);
      return ret;
    } 
  }

  public double ktau_scale {
    set {
      yarpPINVOKE.MotorTorqueParameters_ktau_scale_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.MotorTorqueParameters_ktau_scale_get(swigCPtr);
      return ret;
    } 
  }

  public MotorTorqueParameters() : this(yarpPINVOKE.new_MotorTorqueParameters(), true) {
  }

}