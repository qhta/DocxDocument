namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredAreaSeries))]
public class Area3DChartExtension: IArea3DChartExtension
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
