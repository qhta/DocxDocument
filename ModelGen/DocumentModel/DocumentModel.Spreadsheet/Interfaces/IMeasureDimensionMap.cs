namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public interface IMeasureDimensionMap // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Measure Group Id
  /// </summary>
  public System.UInt32? MeasureGroup { get ; set; }
  
  /// <summary>
  /// Dimension Id
  /// </summary>
  public System.UInt32? Dimension { get ; set; }
  
}
