namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Camera Class.
/// </summary>
public interface Camera: IModelElement
{
  /// <summary>
  ///   prst
  /// </summary>
  public PresetCameraKind? PresetCameraType { get; set; }
}