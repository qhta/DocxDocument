namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the indentation which shall be added before the leading edge of the current table in the document (the left edge in a left-to-right table, and the right edge in a right-to-left table). This indentation should shift the table into the text margin by the specified amount.
/// </summary>
public partial class TableIndentation
{
  
  /// <summary>
  ///   w
  /// </summary>
  public Int32? Width { get; set; }
  
  
  /// <summary>
  ///   type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthUnitKind? Type { get; set; }
  
}
