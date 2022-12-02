namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP KPI.
/// </summary>
public interface IKpi // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// KPI Unique Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// KPI Display Name
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// KPI Display Folder
  /// </summary>
  public String? DisplayFolder { get ; set; }
  
  /// <summary>
  /// KPI Measure Group Name
  /// </summary>
  public String? MeasureGroup { get ; set; }
  
  /// <summary>
  /// Parent KPI
  /// </summary>
  public String? ParentKpi { get ; set; }
  
  /// <summary>
  /// KPI Value Unique Name
  /// </summary>
  public String? Value { get ; set; }
  
  /// <summary>
  /// KPI Goal Unique Name
  /// </summary>
  public String? Goal { get ; set; }
  
  /// <summary>
  /// KPI Status Unique Name
  /// </summary>
  public String? Status { get ; set; }
  
  /// <summary>
  /// KPI Trend Unique Name
  /// </summary>
  public String? Trend { get ; set; }
  
  /// <summary>
  /// KPI Weight Unique Name
  /// </summary>
  public String? Weight { get ; set; }
  
}
