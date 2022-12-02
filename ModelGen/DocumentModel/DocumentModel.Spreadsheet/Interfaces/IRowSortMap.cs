namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row Sort Map.
/// </summary>
public interface IRowSortMap // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ISortMapItemType>? RowSortMapItems { get ; set; }
  
}
