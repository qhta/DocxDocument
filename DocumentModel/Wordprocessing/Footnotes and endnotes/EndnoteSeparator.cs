namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specialized reference Ifor endnote separator
/// </summary>
public class EndnoteSeparator: FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Target IEndnote.
  /// </summary>
  public IEndnote? IEndnote {get; set; }
}
