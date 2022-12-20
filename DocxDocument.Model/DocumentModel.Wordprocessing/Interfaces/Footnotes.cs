namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public partial interface Footnotes
{
  /// <summary>
  /// Gets the FootnotesPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.FootnotesPart? FootnotesPart { get; set; }
  
  public DocumentModel.Wordprocessing.Footnote? Footnote { get; set; }
  
}
