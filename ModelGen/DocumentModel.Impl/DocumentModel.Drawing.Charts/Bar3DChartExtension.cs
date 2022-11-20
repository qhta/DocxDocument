namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredBarSeries))]
public class Bar3DChartExtension: IBar3DChartExtension
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
