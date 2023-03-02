namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Table-Level Property Exceptions.
/// </summary>
public record PreviousTablePropertyExceptions
{
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  public TableWidthType? TableWidth { get; set; }

  /// <summary>
  ///   Table Alignment Exception.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }

  /// <summary>
  ///   Table Cell Spacing Exception.
  /// </summary>
  public TableWidthType? TableCellSpacing { get; set; }

  /// <summary>
  ///   Table Indent from Leading Margin Exception.
  /// </summary>
  public TableIndentation? TableIndentation { get; set; }

  /// <summary>
  ///   Table Borders Exceptions.
  /// </summary>
  public TableBorders? TableBorders { get; set; }

  /// <summary>
  ///   Table Shading Exception.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Table Layout Exception.
  /// </summary>
  public TableLayout? TableLayout { get; set; }

  /// <summary>
  ///   Table Cell Margin Exceptions.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public TableLook? TableLook { get; set; }
}