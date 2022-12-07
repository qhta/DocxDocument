namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public class FootnoteEndnoteTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType>, FootnoteEndnoteType
{
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
  
}
