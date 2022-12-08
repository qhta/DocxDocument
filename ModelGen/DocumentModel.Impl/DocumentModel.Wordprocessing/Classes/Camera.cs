namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public class CameraImpl: ModelElementImpl, Camera
{
  public DocumentFormat.OpenXml.Office2010.Word.Camera? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Camera?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetCameraKind? PresetCameraType
  {
    get => (PresetCameraKind?)OpenXmlElement?.PresetCameraType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetCameraType = (DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues?)value;
    }
  }
  
}
