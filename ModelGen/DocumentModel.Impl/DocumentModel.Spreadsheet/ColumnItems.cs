namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowItem))]
public class ColumnItems: IColumnItems
{
  /// <summary>
  /// Column Item Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
