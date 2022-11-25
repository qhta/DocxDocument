namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public interface IMeasureGroup // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Measure Group Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Measure Group Display Name
  /// </summary>
  public System.String? Caption { get ; set; }
  
}
