namespace DocumentModel.Office.Excel;

/// <summary>
/// Column Sort Map.
/// </summary>
public interface IColumnSortMap // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Excel.ISortMapItemType>? ColumnSortMapItems { get ; set; }
  
}
