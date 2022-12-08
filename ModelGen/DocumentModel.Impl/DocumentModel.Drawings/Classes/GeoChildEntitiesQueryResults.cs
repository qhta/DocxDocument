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
  
  public Collection<GeoChildEntitiesQueryResult>? Items
  {
    get;
    set;
  }
  
}
