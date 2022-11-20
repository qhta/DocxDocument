namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildEntities))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildEntitiesQuery))]
public interface IGeoChildEntitiesQueryResult // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public IGeoChildEntitiesQuery? GeoChildEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public IGeoChildEntities? GeoChildEntities { get ; set; }
  
}
