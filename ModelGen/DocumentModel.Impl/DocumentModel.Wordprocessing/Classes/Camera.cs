namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public class CameraImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Camera>, Camera
{
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
