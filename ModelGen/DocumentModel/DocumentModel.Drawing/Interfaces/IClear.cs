namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public interface IClear // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.Drawing.IGeoLocationQueryResults? GeoLocationQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawing.IGeoDataEntityQueryResults? GeoDataEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawing.IGeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawing.IGeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get ; set; }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawing.IGeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get ; set; }
  
}
