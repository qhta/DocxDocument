namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Camera Class.
/// </summary>
public class Camera: ModelElement
{
  /// <summary>
  ///   prst, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetCameraKind? PresetCameraType { get; set; }
}