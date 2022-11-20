namespace DocumentModel.Office.Excel;

/// <summary>
/// Row.
/// </summary>
public interface IRowSortMapItem // : DocumentFormat.OpenXml.Office.Excel.SortMapItemType
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
