namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP KPI.
/// </summary>
public interface IKpi // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// KPI Unique Name
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// KPI Display Name
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// KPI Display Folder
  /// </summary>
  public string? DisplayFolder { get ; set; }
  
  /// <summary>
  /// KPI Measure Group Name
  /// </summary>
  public string? MeasureGroup { get ; set; }
  
  /// <summary>
  /// Parent KPI
  /// </summary>
  public string? ParentKpi { get ; set; }
  
  /// <summary>
  /// KPI Value Unique Name
  /// </summary>
  public string? Value { get ; set; }
  
  /// <summary>
  /// KPI Goal Unique Name
  /// </summary>
  public string? Goal { get ; set; }
  
  /// <summary>
  /// KPI Status Unique Name
  /// </summary>
  public string? Status { get ; set; }
  
  /// <summary>
  /// KPI Trend Unique Name
  /// </summary>
  public string? Trend { get ; set; }
  
  /// <summary>
  /// KPI Weight Unique Name
  /// </summary>
  public string? Weight { get ; set; }
  
}
