namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public class FootnoteEndnoteTypeImpl: ModelElementImpl, FootnoteEndnoteType
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  public FootnoteEndnoteKind? Type
  {
    get => (FootnoteEndnoteKind?)OpenXmlElement?.Type?.Value;
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
    get;
    set;
  }
  
}
