namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredScatterSeries))]
public class ScatterChartExtension: IScatterChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
