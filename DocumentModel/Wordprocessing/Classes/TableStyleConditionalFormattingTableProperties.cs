namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Style Conditional Formatting Table Properties.
/// </summary>
public class TableStyleConditionalFormattingTableProperties: ModelElement
{
  /// <summary>
  ///   TableJustification.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }

  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  public TableWidthType? TableCellSpacing { get; set; }

  /// <summary>
  ///   TableIndentation.
  /// </summary>
  public TableIndentation? TableIndentation { get; set; }

  /// <summary>
  ///   TableBorders.
  /// </summary>
  public TableBorders? TableBorders { get; set; }

  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault { get; set; }
}