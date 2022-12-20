namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public partial class TitleImpl: ModelElementImpl, Title
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.Title? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Title?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TitleImpl(): base() {}
  
  public TitleImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Title openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Language
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
  /// Value
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
