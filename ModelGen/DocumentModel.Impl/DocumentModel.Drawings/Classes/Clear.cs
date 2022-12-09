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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
