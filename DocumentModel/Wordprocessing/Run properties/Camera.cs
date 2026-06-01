namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Camera Class.
/// </summary>
public class Camera: ModelElement
{
  /// <summary>
  ///   prst, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public PresetCameraKind? PresetCameraType { get; set; }
}
