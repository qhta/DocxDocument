namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base interface for all TableCellProperties classes.
/// Contains common properties for table cell formatting, including shading, text wrapping, margins, and vertical alignment.
/// </summary>
public class BaseTableCellProperties: ModelElement
{

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