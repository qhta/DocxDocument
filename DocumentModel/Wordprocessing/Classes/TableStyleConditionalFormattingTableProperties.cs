namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Style Conditional Formatting Table Properties.
/// </summary>
public record TableStyleConditionalFormattingTableProperties
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