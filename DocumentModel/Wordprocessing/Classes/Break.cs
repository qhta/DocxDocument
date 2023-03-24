namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents a break of line, column or page.
/// </summary>
public class Break: ModelElement, IRunElement
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
  ///   Specifies whether this element represents the position of last rendered page break.
  /// </summary>
  public bool IsLastRendered {get; set; }
}