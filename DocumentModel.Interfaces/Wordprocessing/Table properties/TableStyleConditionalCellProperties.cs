namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public interface TableStyleConditionalCellProperties
{
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }
  /// <summary>
  ///   Shading.
  /// </summary>
  public DMWD.Shading? Shading { get; set; }
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