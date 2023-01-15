using DocumentModel.Drawings.ChartDrawings;
using GeoDataPointToEntityQueryResult = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public static class GeoDataPointToEntityQueryResultConverter
{
  /// <summary>
  ///   GeoDataPointQuery.
  /// </summary>
  public static GeoDataPointQuery? GetGeoDataPointQuery(GeoDataPointToEntityQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery>();
    if (itemElement != null)
      return GeoDataPointQueryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoDataPointQuery(GeoDataPointToEntityQueryResult? openXmlElement, GeoDataPointQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataPointQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GeoDataPointToEntityQuery.
  /// </summary>
  public static GeoDataPointToEntityQuery? GetGeoDataPointToEntityQuery(GeoDataPointToEntityQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery>();
    if (itemElement != null)
      return GeoDataPointToEntityQueryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoDataPointToEntityQuery(GeoDataPointToEntityQueryResult? openXmlElement, GeoDataPointToEntityQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataPointToEntityQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult? CreateModelElement(GeoDataPointToEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult();
      value.GeoDataPointQuery = GetGeoDataPointQuery(openXmlElement);
      value.GeoDataPointToEntityQuery = GetGeoDataPointToEntityQuery(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult? value)
    where OpenXmlElementType : GeoDataPointToEntityQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoDataPointQuery(openXmlElement, value?.GeoDataPointQuery);
      SetGeoDataPointToEntityQuery(openXmlElement, value?.GeoDataPointToEntityQuery);
      return openXmlElement;
    }
    return default;
  }
}