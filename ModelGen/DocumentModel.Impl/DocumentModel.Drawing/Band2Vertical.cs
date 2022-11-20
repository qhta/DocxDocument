namespace DocumentModel.Drawing;

/// <summary>
/// Band 2 Vertical.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellTextStyle))]
public class Band2Vertical: IBand2Vertical
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
