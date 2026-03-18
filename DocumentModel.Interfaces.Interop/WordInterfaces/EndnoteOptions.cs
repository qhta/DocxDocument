namespace DocumentModel.Interop;

/// <summary>
/// Represents the properties assigned to a range or selection of endnotes in a document.
/// </summary>
public interface EndnoteOptions : InteropObject
{
  /// <summary>
  /// The location.
  /// </summary>
  public WdEndnoteLocation Location { get; set; }
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

}
