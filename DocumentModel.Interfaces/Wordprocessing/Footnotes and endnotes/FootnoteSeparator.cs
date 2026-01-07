namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specialized reference for footnote separator
/// </summary>
public interface FootnoteSeparator: CollectionItem, FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Target Footnote.
  /// </summary>
  public Footnote? Footnote {get; set; }
}