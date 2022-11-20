namespace DocumentModel.Office.Excel;

/// <summary>
/// Column Sort Map.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IColumnSortMapItem))]
public class ColumnSortMap: IColumnSortMap
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? Ref
  {
    get;
    set;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
