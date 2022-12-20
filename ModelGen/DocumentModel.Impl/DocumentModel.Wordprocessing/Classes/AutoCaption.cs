namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public partial class AutoCaptionImpl: ModelElementImpl, AutoCaption
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.AutoCaption? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AutoCaption?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AutoCaptionImpl(): base() {}
  
  public AutoCaptionImpl(DocumentFormat.OpenXml.Wordprocessing.AutoCaption openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  public String? Caption
  {
    get => (System.String?)OpenXmlElement?.Caption?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Caption = (System.String?)value;
    }
  }
  
}
