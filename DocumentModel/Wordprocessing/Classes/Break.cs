namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a break of line, column or page.
/// </summary>
public class Break: RunElement
{
  /// <summary>
  ///   Break type
  /// </summary>
  public BreakKind? Type { get; set; }

  /// <summary>
  ///   Restart location for text wrapping break
  /// </summary>
  public BreakTextRestartLocationKind? Clear { get; set; }

  /// <summary>
  ///   Specifies whether this element represents the position of last rendere page break.
  /// </summary>
  public bool IsLastRendered {get; set; }
}