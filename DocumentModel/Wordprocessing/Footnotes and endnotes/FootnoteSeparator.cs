namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specialized reference for footnote separator
/// </summary>
public class FootnoteSeparator: FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Target IFootnote.
  /// </summary>
  public IFootnote? IFootnote {get; set; }
}
