namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public class GeoParentEntitiesQueryResultsImpl: ModelElementImpl, GeoParentEntitiesQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<GeoParentEntitiesQueryResult>? Items
  {
    get;
    set;
  }
  
}
