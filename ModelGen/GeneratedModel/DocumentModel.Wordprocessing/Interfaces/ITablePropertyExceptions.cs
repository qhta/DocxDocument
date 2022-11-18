namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table-Level Property Exceptions.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellMarginDefault))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableLayout))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableLook))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITablePropertyExceptionsChange))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableWidth))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellSpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableIndentation))]
public interface ITablePropertyExceptions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public ITableWidth? TableWidth { get ; set; }
  
  /// <summary>
  /// Table Alignment Exception.
  /// </summary>
  public ITableJustification? TableJustification { get ; set; }
  
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
  
  /// <summary>
  /// Revision Information for Table-Level Property Exceptions.
  /// </summary>
  public ITablePropertyExceptionsChange? TablePropertyExceptionsChange { get ; set; }
  
}
