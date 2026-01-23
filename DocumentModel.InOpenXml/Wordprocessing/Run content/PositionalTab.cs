namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an absolute position tab character in a text run in WordprocessingML documents.
/// An absolute position tab advances the position on the current line of text to a specified alignment and base, regardless of custom tab stops or default tab stop width. If the alignment location cannot be found on the current line, the tab advances to that location on the next available line.
/// </summary>
public class PositionalTab : ModelElement<DXW.PositionalTab>, IRunContent
{

  /// <summary>
  /// Alignment for the positional tab stop, specifying how the tab aligns relative to the target position.
  /// </summary>
  public AbsolutePositionTabAlignmentKind? Alignment { get; set; }

  /// <summary>
  /// Base for the positional tab stop, specifying the reference point for tab alignment (e.g., margin, indent).
  /// </summary>
  public AbsolutePositionTabPositioningBaseKind? RelativeTo { get; set; }

  /// <summary>
  /// Leader character for the tab, specifying the character used to fill the space advanced by the tab.
  /// </summary>
  public AbsolutePositionTabLeaderCharKind? Leader { get; set; }
}