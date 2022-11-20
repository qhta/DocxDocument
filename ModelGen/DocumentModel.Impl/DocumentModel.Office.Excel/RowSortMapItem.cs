namespace DocumentModel.Office.Excel;

/// <summary>
/// Row.
/// </summary>
public class RowSortMapItem: IRowSortMapItem
{
  /// <summary>
  /// New Value
  /// </summary>
  public uint? NewVal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Value
  /// </summary>
  public uint? OldVal
  {
    get;
    set;
  }
  
}
