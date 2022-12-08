namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public GeoDataEntityQuery? GeoDataEntityQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public GeoData? GeoData
  {
    get;
    set;
  }
  
}
