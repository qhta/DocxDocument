namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public partial class HelpTextImpl: ModelElementImpl, HelpText
{
  public DocumentFormat.OpenXml.Wordprocessing.HelpText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.HelpText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HelpTextImpl(): base() {}
  
  public HelpTextImpl(DocumentFormat.OpenXml.Wordprocessing.HelpText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Help Text Type
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
  /// Help Text Value
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
