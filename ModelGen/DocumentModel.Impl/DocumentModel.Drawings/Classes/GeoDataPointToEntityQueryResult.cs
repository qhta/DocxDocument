namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public GeoDataPointQuery? GeoDataPointQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get;
    set;
  }
  
}
