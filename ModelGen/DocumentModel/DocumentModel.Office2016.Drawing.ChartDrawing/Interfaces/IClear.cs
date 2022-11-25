namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public interface IClear // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GeoLocationQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GeoDataEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GeoDataPointToEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GeoChildEntitiesQueryResults { get ; set; }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GeoParentEntitiesQueryResults { get ; set; }
  
}
