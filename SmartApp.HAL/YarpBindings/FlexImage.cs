//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FlexImage : Image {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FlexImage(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.FlexImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FlexImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FlexImage() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_FlexImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public void setPixelCode(int imgPixelCode) {
    yarpPINVOKE.FlexImage_setPixelCode(swigCPtr, imgPixelCode);
  }

  public void setPixelSize(uint imgPixelSize) {
    yarpPINVOKE.FlexImage_setPixelSize(swigCPtr, imgPixelSize);
  }

  public new void setQuantum(uint imgQuantum) {
    yarpPINVOKE.FlexImage_setQuantum(swigCPtr, imgQuantum);
  }

  public FlexImage() : this(yarpPINVOKE.new_FlexImage(), true) {
  }

}