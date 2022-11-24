namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table-Level Property Exceptions.
/// </summary>
public interface IPreviousTablePropertyExceptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public ITableWidth? TableWidth { get ; set; }
  
  /// <summary>
  /// Table Alignment Exception.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues>? TableJustification { get ; set; }
  
  /// <summary>
  /// Table Cell Spacing Exception.
  /// </summary>
  public ITableCellSpacing? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public ITableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public ITableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  public ITableLayout? TableLayout { get ; set; }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public ITableLook? TableLook { get ; set; }
  
}
