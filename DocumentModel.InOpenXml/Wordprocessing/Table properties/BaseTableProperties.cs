namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base interface for all TableProperties classes.
/// Contains common properties for table formatting, including alignment, indentation, cell margins, cell spacing, borders, and shading.
/// </summary>
public interface BaseTableProperties
{

  /// <summary>
  /// Table alignment, specifying horizontal justification of the table within the document.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }

  /// <summary>
  /// Table indent from leading margin, specifying the distance from the document margin to the table.
  /// </summary>
  public TableWidth? TableIndentation { get; set; }

  /// <summary>
  /// Default cell margin for the table, specifying padding for all table cells.
  /// </summary>
  public DefaultTableCellMargin? DefaultTableCellMargin { get; set; }

  /// <summary>
  /// Cell spacing for the table, specifying the space between adjacent cells.
  /// </summary>
  public TableWidth? TableCellSpacing { get; set; }

  /// <summary>
  /// Borders for the table, specifying line style, color, and width for table edges.
  /// </summary>
  public TableBorders? TableBorders { get; set; }

  /// <summary>
  /// Shading applied to the table, specifying background and pattern formatting.
  /// </summary>
  public DMWD.Shading? Shading { get; set; }
}