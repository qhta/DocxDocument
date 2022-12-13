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
  
  public CameraImpl(): base() {}
  
  public CameraImpl(DocumentFormat.OpenXml.Drawing.Camera openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public DocumentModel.Drawings.PresetCameraKind? Preset
  {
    get => (DocumentModel.Drawings.PresetCameraKind?)OpenXmlElement?.Preset?.Value;
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
    get => (System.Int32?)OpenXmlElement?.FieldOfView?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FieldOfView = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public Int32? Zoom
  {
    get => (System.Int32?)OpenXmlElement?.Zoom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Zoom = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public DocumentModel.Drawings.Rotation? Rotation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
