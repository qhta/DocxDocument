namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataEntityQueryResults Class.
/// </summary>
public class GeoDataEntityQueryResultsImpl: ModelElementImpl, GeoDataEntityQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataEntityQueryResultsImpl(): base() {}
  
  public GeoDataEntityQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<GeoDataEntityQueryResult>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
