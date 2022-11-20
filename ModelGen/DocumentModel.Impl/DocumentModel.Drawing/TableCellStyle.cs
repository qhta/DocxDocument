namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ICell3DProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellBorders))]
public class TableCellStyle: ITableCellStyle
{
  /// <summary>
  /// Table Cell Borders.
  /// </summary>
  public DocumentModel.Drawing.ITableCellBorders? TableCellBorders
  {
    get;
    set;
  }
  
}
