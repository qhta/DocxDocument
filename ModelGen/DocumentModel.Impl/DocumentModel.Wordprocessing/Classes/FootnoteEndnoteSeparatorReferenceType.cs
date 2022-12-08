namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public class FootnoteEndnoteSeparatorReferenceTypeImpl: ModelElementImpl, FootnoteEndnoteSeparatorReferenceType
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
