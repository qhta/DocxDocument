namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoPolygons Class.
/// </summary>
public static class GeoPolygonsConverter
{
  private static Collection<DMDrawsChartDraws.GeoPolygon> GetItems(DXO2016DrawChartDraw.GeoPolygons openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoPolygon>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoPolygon>())
    {
      var newItem = DMXDrawsChartDraws.GeoPolygonConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoPolygons openXmlElement, Collection<DMDrawsChartDraws.GeoPolygon>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoPolygon>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoPolygonConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoPolygon>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoPolygons? CreateModelElement(DXO2016DrawChartDraw.GeoPolygons? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoPolygons();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoPolygons? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoPolygons, new()
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
