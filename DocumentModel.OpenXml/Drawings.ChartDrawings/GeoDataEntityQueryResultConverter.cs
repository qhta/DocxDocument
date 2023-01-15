using DocumentModel.Drawings.ChartDrawings;
using GeoDataEntityQueryResult = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQueryResult Class.
/// </summary>
public static class GeoDataEntityQueryResultConverter
{
  /// <summary>
  ///   GeoDataEntityQuery.
  /// </summary>
  public static GeoDataEntityQuery? GetGeoDataEntityQuery(GeoDataEntityQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>();
    if (itemElement != null)
      return GeoDataEntityQueryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoDataEntityQuery(GeoDataEntityQueryResult? openXmlElement, GeoDataEntityQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataEntityQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GeoData.
  /// </summary>
  public static GeoData? GetGeoData(GeoDataEntityQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>();
    if (itemElement != null)
      return GeoDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoData(GeoDataEntityQueryResult? openXmlElement, GeoData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult? CreateModelElement(GeoDataEntityQueryResult? openXmlElement)
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
    where OpenXmlElementType : GeoDataEntityQueryResult, new()
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