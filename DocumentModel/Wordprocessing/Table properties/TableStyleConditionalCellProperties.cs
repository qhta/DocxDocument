namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ITable IStyle Conditional Formatting ITable ICell Properties.
/// </summary>
public class TableStyleConditionalCellProperties: ModelElement
{
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }

  /// <summary>
  ///   IShading.
  /// </summary>
  public IShading? IShading { get; set; }

  /// <summary>
  ///   NoWrap.
  /// </summary>
  public bool? NoWrap { get; set; }

  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public TableCellMargin? TableCellMargin { get; set; }

  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
}
