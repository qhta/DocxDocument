namespace DocumentModel.Office.Excel;

/// <summary>
/// Column.
/// </summary>
public interface IColumnSortMapItem // : DocumentFormat.OpenXml.Office.Excel.SortMapItemType
{
  /// <summary>
  /// New Value
  /// </summary>
  public uint? NewVal { get ; set; }
  
  /// <summary>
  /// Old Value
  /// </summary>
  public uint? OldVal { get ; set; }
  
}
