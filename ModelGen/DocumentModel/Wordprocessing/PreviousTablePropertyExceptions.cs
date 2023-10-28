namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of table properties which shall be applied to the contents of this row in place of the table properties specified in the tblPr element.
/// </summary>
public partial class PreviousTablePropertyExceptions
{
  
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  public DMW.TableWidth? TableWidth { get; set; }
  
  
  /// <summary>
  ///   Table Alignment Exception.
  /// </summary>
  public DMW.TableRowAlignmentKind? TableJustification { get; set; }
  
  
  /// <summary>
  ///   Table Cell Spacing Exception.
  /// </summary>
  public DMW.TableCellSpacing? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   Table Indent from Leading Margin Exception.
  /// </summary>
  public DMW.TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   Table Borders Exceptions.
  /// </summary>
  public DMW.TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Table Shading Exception.
  /// </summary>
  public DMW.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   Table Layout Exception.
  /// </summary>
  public DMW.TableLayout? TableLayout { get; set; }
  
  
  /// <summary>
  ///   Table Cell Margin Exceptions.
  /// </summary>
  public DMW.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public DMW.TableLook? TableLook { get; set; }
  
}
