namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public interface IMeasureGroup // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Measure Group Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Measure Group Display Name
  /// </summary>
  public String? Caption { get ; set; }
  
}
