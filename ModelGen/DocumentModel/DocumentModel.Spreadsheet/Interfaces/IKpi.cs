namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP KPI.
/// </summary>
public interface IKpi // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// KPI Unique Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// KPI Display Name
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// KPI Display Folder
  /// </summary>
  public System.String? DisplayFolder { get ; set; }
  
  /// <summary>
  /// KPI Measure Group Name
  /// </summary>
  public System.String? MeasureGroup { get ; set; }
  
  /// <summary>
  /// Parent KPI
  /// </summary>
  public System.String? ParentKpi { get ; set; }
  
  /// <summary>
  /// KPI Value Unique Name
  /// </summary>
  public System.String? Value { get ; set; }
  
  /// <summary>
  /// KPI Goal Unique Name
  /// </summary>
  public System.String? Goal { get ; set; }
  
  /// <summary>
  /// KPI Status Unique Name
  /// </summary>
  public System.String? Status { get ; set; }
  
  /// <summary>
  /// KPI Trend Unique Name
  /// </summary>
  public System.String? Trend { get ; set; }
  
  /// <summary>
  /// KPI Weight Unique Name
  /// </summary>
  public System.String? Weight { get ; set; }
  
}
