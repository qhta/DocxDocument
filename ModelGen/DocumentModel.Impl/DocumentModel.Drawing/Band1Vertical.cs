namespace DocumentModel.Drawing;

/// <summary>
/// Band 1 Vertical.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellTextStyle))]
public class Band1Vertical: IBand1Vertical
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
