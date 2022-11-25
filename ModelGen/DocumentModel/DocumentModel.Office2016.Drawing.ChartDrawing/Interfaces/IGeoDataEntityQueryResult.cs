namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public interface IGeoDataEntityQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataEntityQuery? GeoDataEntityQuery { get ; set; }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoData? GeoData { get ; set; }
  
}
