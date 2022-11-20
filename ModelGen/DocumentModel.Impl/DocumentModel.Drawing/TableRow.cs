namespace DocumentModel.Drawing;

/// <summary>
/// Table Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCell))]
public class TableRow: ITableRow
{
  /// <summary>
  /// Height
  /// </summary>
  public long? Height
  {
    get;
    set;
  }
  
}
