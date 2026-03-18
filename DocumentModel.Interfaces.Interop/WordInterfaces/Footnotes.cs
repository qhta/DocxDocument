namespace DocumentModel.Interop;

/// <summary>
/// A collection of Footnote objects that represent all the footnotes in a selection, range, or document.
/// </summary>
public partial interface Footnotes : InteropObject, InteropCollection<Footnote>
{
  /// <summary>
  /// The location.
  /// </summary>
  public WdFootnoteLocation Location { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  public WdNoteNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The starting number.
  /// </summary>
  public int StartingNumber { get; set; }

  /// <summary>
  /// The numbering rule.
  /// </summary>
  public WdNumberingRule NumberingRule { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  public Range Separator { get; }

  /// <summary>
  /// The continuation separator.
  /// </summary>
  public Range ContinuationSeparator { get; }

  /// <summary>
  /// The continuation notice.
  /// </summary>
  public Range ContinuationNotice { get; }
}
