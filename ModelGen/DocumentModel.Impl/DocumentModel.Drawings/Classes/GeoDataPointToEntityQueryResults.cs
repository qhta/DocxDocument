namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public class GeoDataPointToEntityQueryResultsImpl: ModelElementImpl, GeoDataPointToEntityQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataPointToEntityQueryResultsImpl(): base() {}
  
  public GeoDataPointToEntityQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<GeoDataPointToEntityQueryResult>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
