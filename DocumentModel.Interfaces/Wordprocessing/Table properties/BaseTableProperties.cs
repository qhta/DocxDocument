namespace DocumentModel.Wordprocessing;
/// <summary>
///   Base class for all TableProperties classes.
///   Contains common properties.
/// </summary>
public abstract class BaseTableProperties: ModelElement
{
  /// <summary>
  ///   Table Alignment.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }
  /// <summary>
  ///   Table Indent from Leading Margin.
  /// </summary>
  public TableWidth? TableIndentation { get; set; }
  /// <summary>
  ///   Table Cell Margin.
  /// </summary>
  public DefaultTableCellMargin? DefaultTableCellMargin { get; set; }
  /// <summary>
  ///   Table Cell Spacing.
  /// </summary>
  public TableWidth? TableCellSpacing { get; set; }
  /// <summary>
  ///   Table Borders..
  /// </summary>
  public TableBorders? TableBorders { get; set; }
  /// <summary>
  ///   Table Shading.
  /// </summary>
  public Shading? Shading { get; set; }
}