namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public static class GeoDataEntityQueryResultConverter
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery? GetGeoDataEntityQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataEntityQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoDataEntityQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataEntityQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoData? GetGeoData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult();
      value.GeoDataEntityQuery = GetGeoDataEntityQuery(openXmlElement);
      value.GeoData = GetGeoData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoDataEntityQuery(openXmlElement, value?.GeoDataEntityQuery);
      SetGeoData(openXmlElement, value?.GeoData);
      return openXmlElement;
    }
    return default;
  }
}
