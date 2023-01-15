using DocumentModel.Drawings.ChartDrawings;
using GeoChildEntitiesQueryResult = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public static class GeoChildEntitiesQueryResultConverter
{
  /// <summary>
  ///   GeoChildEntitiesQuery.
  /// </summary>
  public static GeoChildEntitiesQuery? GetGeoChildEntitiesQuery(GeoChildEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>();
    if (itemElement != null)
      return GeoChildEntitiesQueryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoChildEntitiesQuery(GeoChildEntitiesQueryResult? openXmlElement, GeoChildEntitiesQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildEntitiesQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GeoChildEntities.
  /// </summary>
  public static GeoChildEntities? GetGeoChildEntities(GeoChildEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>();
    if (itemElement != null)
      return GeoChildEntitiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoChildEntities(GeoChildEntitiesQueryResult? openXmlElement, GeoChildEntities? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildEntitiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult? CreateModelElement(GeoChildEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult();
      value.GeoChildEntitiesQuery = GetGeoChildEntitiesQuery(openXmlElement);
      value.GeoChildEntities = GetGeoChildEntities(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult? value)
    where OpenXmlElementType : GeoChildEntitiesQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoChildEntitiesQuery(openXmlElement, value?.GeoChildEntitiesQuery);
      SetGeoChildEntities(openXmlElement, value?.GeoChildEntities);
      return openXmlElement;
    }
    return default;
  }
}