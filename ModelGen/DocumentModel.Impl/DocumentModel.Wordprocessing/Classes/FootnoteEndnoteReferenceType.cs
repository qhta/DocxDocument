namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public class FootnoteEndnoteReferenceTypeImpl: ModelElementImpl, FootnoteEndnoteReferenceType
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public Boolean? CustomMarkFollows
  {
    get;
    set;
  }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  public Int32? Id
  {
    get;
    set;
  }
  
}
