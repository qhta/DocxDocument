namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public partial class CameraImpl: ModelElementImpl, Camera
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.Camera? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Camera?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CameraImpl(): base() {}
  
  public CameraImpl(DocumentFormat.OpenXml.Office2010.Word.Camera openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PresetCameraKind? PresetCameraType
  {
    get => (DocumentModel.Wordprocessing.PresetCameraKind?)OpenXmlElement?.PresetCameraType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetCameraType = (DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues?)value;
    }
  }
  
}
