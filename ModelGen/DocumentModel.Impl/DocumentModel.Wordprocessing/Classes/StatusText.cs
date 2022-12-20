namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public partial class StatusTextImpl: ModelElementImpl, StatusText
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.StatusText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.StatusText?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StatusTextImpl(): base() {}
  
  public StatusTextImpl(DocumentFormat.OpenXml.Wordprocessing.StatusText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Status Text Type
  /// </summary>
  public DocumentModel.Wordprocessing.InfoTextKind? Type
  {
    get => (DocumentModel.Wordprocessing.InfoTextKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.InfoTextValues?)value;
    }
  }
  
  /// <summary>
  /// Status Text Value
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
