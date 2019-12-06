#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkEmitterSettings : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkEmitterSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkEmitterSettings obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkEmitterSettings() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkEmitterSettings(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkEmitterSettings() : this(AkSoundEnginePINVOKE.CSharp_new_AkEmitterSettings(), true) {
  }

  public uint reflectAuxBusID { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectAuxBusID_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectAuxBusID_get(swigCPtr); } 
  }

  public float reflectionMaxPathLength { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionMaxPathLength_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionMaxPathLength_get(swigCPtr); } 
  }

  public float reflectionsAuxBusGain { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsAuxBusGain_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsAuxBusGain_get(swigCPtr); } 
  }

  public uint reflectionsOrder { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsOrder_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectionsOrder_get(swigCPtr); } 
  }

  public uint reflectorFilterMask { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectorFilterMask_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_reflectorFilterMask_get(swigCPtr); } 
  }

  public float roomReverbAuxBusGain { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_roomReverbAuxBusGain_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_roomReverbAuxBusGain_get(swigCPtr); } 
  }

  public byte useImageSources { set { AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_useImageSources_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkEmitterSettings_useImageSources_get(swigCPtr); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.