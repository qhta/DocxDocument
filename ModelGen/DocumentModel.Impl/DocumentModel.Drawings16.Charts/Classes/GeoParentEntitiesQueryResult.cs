namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public class GeoParentEntitiesQueryResultImpl: ModelElementImpl, GeoParentEntitiesQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoParentEntitiesQueryResultImpl(): base() {}
  
  public GeoParentEntitiesQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoEntity? GeoEntity
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoParentEntity? GeoParentEntity
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
