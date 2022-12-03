namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Sort Map.
/// </summary>
public interface ColumnSortMap // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<SortMapItemType>? ColumnSortMapItems { get ; set; }
  
}
