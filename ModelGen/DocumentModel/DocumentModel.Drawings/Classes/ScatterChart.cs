namespace DocumentModel.Drawings;

/// <summary>
/// Scatter Charts.
/// </summary>
public class ScatterChart
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle
  {
    get;
    set;
  }
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public ScatterChartExtensionList? ScatterChartExtensionList
  {
    get;
    set;
  }
  
}
