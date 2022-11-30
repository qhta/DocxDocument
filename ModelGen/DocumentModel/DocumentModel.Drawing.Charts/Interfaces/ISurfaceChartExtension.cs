namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public interface ISurfaceChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
