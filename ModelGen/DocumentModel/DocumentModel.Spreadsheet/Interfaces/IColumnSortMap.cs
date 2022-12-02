namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Sort Map.
/// </summary>
public interface IColumnSortMap // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ISortMapItemType>? ColumnSortMapItems { get ; set; }
  
}
