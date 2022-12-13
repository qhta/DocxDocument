namespace DocumentModel.Drawings16.Charts;

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
  
  public ClearImpl(): base() {}
  
  public ClearImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoLocationQueryResults? GeoLocationQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
