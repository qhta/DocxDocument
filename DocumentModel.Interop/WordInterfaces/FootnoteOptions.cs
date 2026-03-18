namespace DocumentModel.Interop;

/// <summary>
/// Represents the properties assigned to a range or selection of footnotes in a document.
/// </summary>
public interface FootnoteOptions : InteropObject
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
  /// The layout columns.
  /// </summary>
  public int LayoutColumns { get; set; }

}
