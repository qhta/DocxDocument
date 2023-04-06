namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public class TableStyleConditionalCellProperties: ModelElement
{
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }

  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   NoWrap.
  /// </summary>
  public Boolean? NoWrap { get; set; }

  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public TableCellMargin? TableCellMargin { get; set; }

  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
}