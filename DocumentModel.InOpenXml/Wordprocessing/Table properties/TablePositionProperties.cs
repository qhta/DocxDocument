namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the position properties for a table in a Wordprocessing document.
/// This interface provides properties for specifying distances from text, anchor settings, and alignment, enabling precise control over table placement and layout within the document.
/// </summary>
public class TablePositionProperties: ModelElement
{
  /// <summary>
  /// Distance from the left edge of the table to the surrounding text.
  /// </summary>
  public Int16? LeftFromText { get; set; }

  /// <summary>
  /// Distance from the right edge of the table to the surrounding text.
  /// </summary>
  public Int16? RightFromText { get; set; }

  /// <summary>
  /// Distance from the top edge of the table to the surrounding text.
  /// </summary>
  public Int16? TopFromText { get; set; }

  /// <summary>
  /// Distance from the bottom edge of the table to the surrounding text.
  /// </summary>
  public Int16? BottomFromText { get; set; }

  /// <summary>
  /// Table vertical anchor, specifying the reference point for vertical positioning.
  /// </summary>
  public VerticalAnchorKind? VerticalAnchor { get; set; }

  /// <summary>
  /// Table horizontal anchor, specifying the reference point for horizontal positioning.
  /// </summary>
  public HorizontalAnchorKind? HorizontalAnchor { get; set; }

  /// <summary>
  /// Relative horizontal alignment from anchor, specifying how the table is aligned horizontally relative to its anchor.
  /// </summary>
  public HorizontalAlignmentKind? TablePositionXAlignment { get; set; }

  /// <summary>
  /// Absolute horizontal distance from anchor, specifying the offset from the anchor point.
  /// </summary>
  public Int32? TablePositionX { get; set; }

  /// <summary>
  /// Relative vertical alignment from anchor, specifying how the table is aligned vertically relative to its anchor.
  /// </summary>
  public VerticalAlignmentKind? TablePositionYAlignment { get; set; }

  /// <summary>
  /// Absolute vertical distance from anchor, specifying the offset from the anchor point.
  /// </summary>
  public Int32? TablePositionY { get; set; }
}