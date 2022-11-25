namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public interface IGeoDataPointToEntityQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataPointQuery? GeoDataPointQuery { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get ; set; }
  
}
