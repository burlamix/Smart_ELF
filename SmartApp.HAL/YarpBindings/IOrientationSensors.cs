//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IOrientationSensors : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IOrientationSensors(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IOrientationSensors obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IOrientationSensors() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IOrientationSensors(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual uint getNrOfOrientationSensors() {
    uint ret = yarpPINVOKE.IOrientationSensors_getNrOfOrientationSensors(swigCPtr);
    return ret;
  }

  public virtual MAS_status getOrientationSensorStatus(uint sens_index) {
    MAS_status ret = (MAS_status)yarpPINVOKE.IOrientationSensors_getOrientationSensorStatus(swigCPtr, sens_index);
    return ret;
  }

  public virtual bool getOrientationSensorName(uint sens_index, SWIGTYPE_p_std__string name) {
    bool ret = yarpPINVOKE.IOrientationSensors_getOrientationSensorName(swigCPtr, sens_index, SWIGTYPE_p_std__string.getCPtr(name));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getOrientationSensorFrameName(uint sens_index, SWIGTYPE_p_std__string frameName) {
    bool ret = yarpPINVOKE.IOrientationSensors_getOrientationSensorFrameName(swigCPtr, sens_index, SWIGTYPE_p_std__string.getCPtr(frameName));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getOrientationSensorMeasureAsRollPitchYaw(uint sens_index, Vector rpy, SWIGTYPE_p_double timestamp) {
    bool ret = yarpPINVOKE.IOrientationSensors_getOrientationSensorMeasureAsRollPitchYaw(swigCPtr, sens_index, Vector.getCPtr(rpy), SWIGTYPE_p_double.getCPtr(timestamp));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}