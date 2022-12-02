namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortMapItemType Class.
/// </summary>
public interface ISortMapItemType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// New Value
  /// </summary>
  public UInt32? NewVal { get ; set; }
  
  /// <summary>
  /// Old Value
  /// </summary>
  public UInt32? OldVal { get ; set; }
  
}
