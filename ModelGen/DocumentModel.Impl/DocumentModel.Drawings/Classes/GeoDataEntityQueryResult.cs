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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public GeoData? GeoData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
