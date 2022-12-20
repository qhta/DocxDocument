namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public partial interface Endnotes
{
  /// <summary>
  /// Gets the EndnotesPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.EndnotesPart? EndnotesPart { get; set; }
  
  public DocumentModel.Wordprocessing.Endnote? Endnote { get; set; }
  
}
