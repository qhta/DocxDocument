namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public partial class NoLineBreaksBeforeKinsokuImpl: ModelElementImpl, NoLineBreaksBeforeKinsoku
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NoLineBreaksBeforeKinsokuImpl(): base() {}
  
  public NoLineBreaksBeforeKinsokuImpl(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language
  {
    get => (System.String?)OpenXmlElement?.Language?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = (System.String?)value;
    }
  }
  
  /// <summary>
  /// val
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
