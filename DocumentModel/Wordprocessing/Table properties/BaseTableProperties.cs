namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for all TableProperties classes.
///   Contains common properties.
/// </summary>
public abstract class BaseTableProperties: ModelElement
{
  /// <summary>
  ///   Preferred Table Width.
  /// </summary>
  public TableWidth? TableWidth { get; set; }

  /// <summary>
  ///   Table Alignment.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }

  /// <summary>
  ///   Table Cell Spacing.
  /// </summary>
  public TableWidth? TableCellSpacing { get; set; }

  /// <summary>
  ///   Table Indent from Leading Margin.
  /// </summary>
  public TableIndentation? TableIndentation { get; set; }

  /// <summary>
  ///   Table Borders..
  /// </summary>
  public TableBorders? TableBorders { get; set; }

  /// <summary>
  ///   Table Shading.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Table Layout.
  /// </summary>
  public TableLayout? TableLayout { get; set; }

  /// <summary>
  ///   Table Cell Margin..
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Settings.
  /// </summary>
  public TableLook? TableLook { get; set; }
}