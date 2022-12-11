namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public class GeoChildEntitiesQueryResultsImpl: ModelElementImpl, GeoChildEntitiesQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoChildEntitiesQueryResultsImpl(): base() {}
  
  public GeoChildEntitiesQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<GeoChildEntitiesQueryResult>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
