namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public class GeoChildEntitiesQueryResultImpl: ModelElementImpl, GeoChildEntitiesQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoChildEntitiesQueryResultImpl(): base() {}
  
  public GeoChildEntitiesQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoChildEntities? GeoChildEntities
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
