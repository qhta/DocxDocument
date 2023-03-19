namespace DocumentModel.Wordprocessing;

/// <summary>
///   Style Table Properties.
/// </summary>
public class StyleTableProperties: ModelElement
{
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  public Int32? TableStyleRowBandSize { get; set; }

  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize { get; set; }

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