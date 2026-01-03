namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specialized reference for endnote separator
/// </summary>
public interface EndnoteSeparator: FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Target Endnote.
  /// </summary>
  public Endnote? Endnote {get; set; }
}