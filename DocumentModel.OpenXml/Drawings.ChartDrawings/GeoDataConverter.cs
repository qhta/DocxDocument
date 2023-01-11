namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public static class GeoDataConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }
  
  public static void SetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  public static void SetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// east, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetEast(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    return openXmlElement?.East?.Value;
  }
  
  public static void SetEast(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.East = value;
  }
  
  /// <summary>
  /// west, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetWest(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    return openXmlElement?.West?.Value;
  }
  
  public static void SetWest(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.West = value;
  }
  
  /// <summary>
  /// north, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetNorth(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    return openXmlElement?.North?.Value;
  }
  
  public static void SetNorth(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.North = value;
  }
  
  /// <summary>
  /// south, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetSouth(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    return openXmlElement?.South?.Value;
  }
  
  public static void SetSouth(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.South = value;
  }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoPolygons? GetGeoPolygons(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoPolygonsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoPolygons(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoPolygons? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoPolygonsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Copyrights? GetCopyrights(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.CopyrightsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCopyrights(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement, DocumentModel.Drawings.ChartDrawings.Copyrights? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.CopyrightsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoData? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoData();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      value.East = GetEast(openXmlElement);
      value.West = GetWest(openXmlElement);
      value.North = GetNorth(openXmlElement);
      value.South = GetSouth(openXmlElement);
      value.GeoPolygons = GetGeoPolygons(openXmlElement);
      value.Copyrights = GetCopyrights(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
