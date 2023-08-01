//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace maf {

public class IMediaPipeline : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IMediaPipeline(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IMediaPipeline obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(IMediaPipeline obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~IMediaPipeline() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          mafPINVOKE.delete_IMediaPipeline(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual BufferInfo bufferInfo(int idx) {
    global::System.IntPtr cPtr = mafPINVOKE.IMediaPipeline_bufferInfo(swigCPtr, idx);
    BufferInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new BufferInfo(cPtr, false);
    return ret;
  }

  public virtual PipelineState state() {
    PipelineState ret = (PipelineState)mafPINVOKE.IMediaPipeline_state(swigCPtr);
    return ret;
  }

  public virtual void initialize(MediaInfo mediaInfo, BufferInfoArray buffers) {
    mafPINVOKE.IMediaPipeline_initialize(swigCPtr, MediaInfo.getCPtr(mediaInfo), BufferInfoArray.getCPtr(buffers));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setStateChangeCallback(SWIGTYPE_p_f___void onStateChange) {
    mafPINVOKE.IMediaPipeline_setStateChangeCallback(swigCPtr, SWIGTYPE_p_f___void.getCPtr(onStateChange));
  }

  public virtual void startFetching(TimeInfo timeInfo, ViewInfo viewInfo) {
    mafPINVOKE.IMediaPipeline_startFetching(swigCPtr, TimeInfo.getCPtr(timeInfo), ViewInfo.getCPtr(viewInfo));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void updateView(ViewInfo viewInfo) {
    mafPINVOKE.IMediaPipeline_updateView(swigCPtr, ViewInfo.getCPtr(viewInfo));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void stopFetching() {
    mafPINVOKE.IMediaPipeline_stopFetching(swigCPtr);
  }

}

}
