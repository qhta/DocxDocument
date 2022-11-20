namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredSurfaceSeries))]
public interface ISurfaceChartExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
