namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredSurfaceSeries))]
public class Surface3DChartExtension: ISurface3DChartExtension
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
