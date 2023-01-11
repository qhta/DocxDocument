namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public static class GeoLocationQueryResultConverter
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? GetGeoLocationQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoLocationQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoLocations? GetGeoLocations(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoLocations(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoLocations? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult();
      value.GeoLocationQuery = GetGeoLocationQuery(openXmlElement);
      value.GeoLocations = GetGeoLocations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
