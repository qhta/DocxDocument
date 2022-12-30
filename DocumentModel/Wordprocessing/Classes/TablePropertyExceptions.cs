namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table-Level Property Exceptions.
/// </summary>
public partial class TablePropertyExceptions
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableWidth { get; set; }
  
  /// <summary>
  /// Table Alignment Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get; set; }
  
  /// <summary>
  /// Table Cell Spacing Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing { get; set; }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation { get; set; }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders { get; set; }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout { get; set; }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook { get; set; }
  
  /// <summary>
  /// Revision Information for Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePropertyExceptionsChange? TablePropertyExceptionsChange { get; set; }
  
}
