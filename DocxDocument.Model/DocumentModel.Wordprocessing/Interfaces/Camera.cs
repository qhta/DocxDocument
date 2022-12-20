namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public partial interface Camera
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PresetCameraKind? PresetCameraType { get; set; }
  
}
