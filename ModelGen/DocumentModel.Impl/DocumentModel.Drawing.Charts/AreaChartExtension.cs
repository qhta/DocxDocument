namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredAreaSeries))]
public class AreaChartExtension: IAreaChartExtension
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
