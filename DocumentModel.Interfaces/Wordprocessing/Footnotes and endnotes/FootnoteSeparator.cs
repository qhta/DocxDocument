namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specialized reference for footnote separator
/// </summary>
public class FootnoteSeparator: FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Target Footnote.
  /// </summary>
  public Footnote? Footnote {get; set; }
}