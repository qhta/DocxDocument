namespace DocumentModel.Office.Excel;

/// <summary>
/// Defines the SortMapItemType Class.
/// </summary>
public interface ISortMapItemType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// New Value
  /// </summary>
  public System.UInt32? NewVal { get ; set; }
  
  /// <summary>
  /// Old Value
  /// </summary>
  public System.UInt32? OldVal { get ; set; }
  
}
