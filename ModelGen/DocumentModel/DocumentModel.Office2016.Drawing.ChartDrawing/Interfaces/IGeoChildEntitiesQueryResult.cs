namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public interface IGeoChildEntitiesQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildEntitiesQuery? GeoChildEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GeoChildEntities { get ; set; }
  
}
