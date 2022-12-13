namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public class GeoDataEntityQueryResultImpl: ModelElementImpl, GeoDataEntityQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataEntityQueryResultImpl(): base() {}
  
  public GeoDataEntityQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataEntityQuery? GeoDataEntityQuery
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoData? GeoData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
