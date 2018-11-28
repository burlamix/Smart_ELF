//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IImpedanceControlRaw : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IImpedanceControlRaw(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IImpedanceControlRaw obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IImpedanceControlRaw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IImpedanceControlRaw(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int ax) {
    bool ret = yarpPINVOKE.IImpedanceControlRaw_getAxes(swigCPtr, SWIGTYPE_p_int.getCPtr(ax));
    return ret;
  }

  public virtual bool getImpedanceRaw(int j, SWIGTYPE_p_double stiffness, SWIGTYPE_p_double damping) {
    bool ret = yarpPINVOKE.IImpedanceControlRaw_getImpedanceRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(stiffness), SWIGTYPE_p_double.getCPtr(damping));
    return ret;
  }

  public virtual bool setImpedanceRaw(int j, double stiffness, double damping) {
    bool ret = yarpPINVOKE.IImpedanceControlRaw_setImpedanceRaw(swigCPtr, j, stiffness, damping);
    return ret;
  }

  public virtual bool setImpedanceOffsetRaw(int j, double offset) {
    bool ret = yarpPINVOKE.IImpedanceControlRaw_setImpedanceOffsetRaw(swigCPtr, j, offset);
    return ret;
  }

  public virtual bool getImpedanceOffsetRaw(int j, SWIGTYPE_p_double offset) {
    bool ret = yarpPINVOKE.IImpedanceControlRaw_getImpedanceOffsetRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(offset));
    return ret;
  }

  public virtual bool getCurrentImpedanceLimitRaw(int j, SWIGTYPE_p_double min_stiff, SWIGTYPE_p_double max_stiff, SWIGTYPE_p_double min_damp, SWIGTYPE_p_double max_damp) {
    bool ret = yarpPINVOKE.IImpedanceControlRaw_getCurrentImpedanceLimitRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(min_stiff), SWIGTYPE_p_double.getCPtr(max_stiff), SWIGTYPE_p_double.getCPtr(min_damp), SWIGTYPE_p_double.getCPtr(max_damp));
    return ret;
  }

}