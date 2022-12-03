namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row Sort Map.
/// </summary>
public interface RowSortMap // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<SortMapItemType>? RowSortMapItems { get ; set; }
  
}
