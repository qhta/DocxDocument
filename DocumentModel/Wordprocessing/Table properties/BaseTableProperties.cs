namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class Ifor all TableProperties classes.
///   Contains common properties.
/// </summary>
public abstract class BaseTableProperties: ModelElement
{
  /// <summary>
  ///   ITable Alignment.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }

  /// <summary>
  ///   ITable Indent from Leading Margin.
  /// </summary>
  public TableWidth? TableIndentation { get; set; }

  /// <summary>
  ///   ITable ICell Margin.
  /// </summary>
  public DefaultTableCellMargin? DefaultTableCellMargin { get; set; }

  /// <summary>
  ///   ITable ICell Spacing.
  /// </summary>
  public TableWidth? TableCellSpacing { get; set; }

  /// <summary>
  ///   ITable IBorders..
  /// </summary>
  public TableBorders? TableBorders { get; set; }

  /// <summary>
  ///   ITable IShading.
  /// </summary>
  public IShading? IShading { get; set; }
}
