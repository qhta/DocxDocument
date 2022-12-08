namespace DocumentModel.Drawings;

/// <summary>
/// Camera.
/// </summary>
public class CameraImpl: ModelElementImpl, Camera
{
  public DocumentFormat.OpenXml.Drawing.Camera? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Camera?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// Field of View
  /// </summary>
  public Int32? FieldOfView
  {
    get;
    set;
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public Int32? Zoom
  {
    get;
    set;
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
