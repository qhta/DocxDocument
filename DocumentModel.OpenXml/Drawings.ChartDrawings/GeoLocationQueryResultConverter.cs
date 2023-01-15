using DocumentModel.Drawings.ChartDrawings;
using GeoLocationQueryResult = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public static class GeoLocationQueryResultConverter
{
  /// <summary>
  ///   GeoLocationQuery.
  /// </summary>
  public static GeoLocationQuery? GetGeoLocationQuery(GeoLocationQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>();
    if (itemElement != null)
      return GeoLocationQueryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoLocationQuery(GeoLocationQueryResult? openXmlElement, GeoLocationQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GeoLocations.
  /// </summary>
  public static GeoLocations? GetGeoLocations(GeoLocationQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>();
    if (itemElement != null)
      return GeoLocationsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoLocations(GeoLocationQueryResult? openXmlElement, GeoLocations? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult? CreateModelElement(GeoLocationQueryResult? openXmlElement)
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
    where OpenXmlElementType : GeoLocationQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoLocationQuery(openXmlElement, value?.GeoLocationQuery);
      SetGeoLocations(openXmlElement, value?.GeoLocations);
      return openXmlElement;
    }
    return default;
  }
}