namespace DocumentModel.Drawing;

/// <summary>
/// First Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellTextStyle))]
public class FirstRow: IFirstRow
{
  /// <summary>
  /// Table Cell Text Style.
  /// </summary>
  public ITableCellTextStyle? TableCellTextStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Style.
  /// </summary>
  public ITableCellStyle? TableCellStyle
  {
    get;
    set;
  }
  
}
