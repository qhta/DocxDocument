namespace DocumentModel.Office.Excel;

/// <summary>
/// Row Sort Map.
/// </summary>
public interface IRowSortMap // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
}
