using DocumentModel.Drawings.ChartDrawings;
using GeoPolygons = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoPolygons Class.
/// </summary>
public static class GeoPolygonsConverter
{
  public static Collection<GeoPolygon>? GetItems(GeoPolygons? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GeoPolygon>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>())
      {
        var newItem = GeoPolygonConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(GeoPolygons? openXmlElement, Collection<GeoPolygon>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GeoPolygonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoPolygons? CreateModelElement(GeoPolygons? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoPolygons();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoPolygons? value)
    where OpenXmlElementType : GeoPolygons, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}