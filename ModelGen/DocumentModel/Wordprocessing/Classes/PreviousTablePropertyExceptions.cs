namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of table properties which shall be applied to the contents of this row in place of the table properties specified in the tblPr element.
/// </summary>
public partial class PreviousTablePropertyExceptions
{
  
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableWidth { get; set; }
  
  
  /// <summary>
  ///   Table Alignment Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentValues? TableJustification { get; set; }
  
  
  /// <summary>
  ///   Table Cell Spacing Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   Table Indent from Leading Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   Table Borders Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Table Shading Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   Table Layout Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout { get; set; }
  
  
  /// <summary>
  ///   Table Cell Margin Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook { get; set; }
  
}
