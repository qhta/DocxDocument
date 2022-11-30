namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public interface IClear // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocationQueryResults? GeoLocationQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataEntityQueryResults? GeoDataEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get ; set; }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get ; set; }
  
}
