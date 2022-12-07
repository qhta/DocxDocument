namespace DocumentModel.Drawings;

/// <summary>
/// Camera.
/// </summary>
public class CameraImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Camera>, Camera
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public PresetCameraKind? Preset
  {
    get => (PresetCameraKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.PresetCameraValues?)value;
    }
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public Rotation? Rotation
  {
    get;
    set;
  }
  
}
