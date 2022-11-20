namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredSurfaceSeries))]
public class SurfaceChartExtension: ISurfaceChartExtension
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
