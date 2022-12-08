namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public class ClearImpl: ModelElementImpl, Clear
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public GeoLocationQueryResults? GeoLocationQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get;
    set;
  }
  
}
