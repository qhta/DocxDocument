namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public class GeoDataPointToEntityQueryResultImpl: ModelElementImpl, GeoDataPointToEntityQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataPointToEntityQueryResultImpl(): base() {}
  
  public GeoDataPointToEntityQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataPointQuery? GeoDataPointQuery
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
