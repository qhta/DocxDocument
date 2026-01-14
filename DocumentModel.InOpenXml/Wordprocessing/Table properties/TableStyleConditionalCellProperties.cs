namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents table style conditional formatting properties for a table cell in a Wordprocessing document.
/// This interface provides properties for borders, shading, text wrapping, margins, and vertical alignment, enabling advanced styling and formatting options for table cells based on conditional formatting rules.
/// </summary>
public class TableStyleConditionalCellProperties: ModelElement
{
  /// <summary>
  /// Table cell borders, specifying the style and appearance of cell edges.
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }

  /// <summary>
  /// Shading applied to the table cell, specifying background and pattern formatting.
  /// </summary>
  public DMWD.Shading? Shading { get; set; }

  /// <summary>
  /// Indicates whether text wrapping is disabled for the cell.
  /// </summary>
  public bool? NoWrap { get; set; }

  /// <summary>
  /// Margins for the table cell, specifying padding on each side.
  /// </summary>
  public TableCellMargin? TableCellMargin { get; set; }

  /// <summary>
  /// Vertical alignment of content within the table cell.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
}