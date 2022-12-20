namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public partial class FootnoteEndnoteTypeImpl: ModelElementImpl, FootnoteEndnoteType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FootnoteEndnoteTypeImpl(): base() {}
  
  public FootnoteEndnoteTypeImpl(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteEndnoteKind? Type
  {
    get => (DocumentModel.Wordprocessing.FootnoteEndnoteKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteValues?)value;
    }
  }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public Int32? Id
  {
    get => (System.Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
}
