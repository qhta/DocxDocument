namespace DocumentModel.Office.Excel;

/// <summary>
/// Row Sort Map.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IRowSortMapItem))]
public class RowSortMap: IRowSortMap
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
