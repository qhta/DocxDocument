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
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoPolygons openXmlElement, Collection<DMDrawsChartDraws.GeoPolygon>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.GeoPolygon>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsChartDraws.GeoPolygonConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoPolygons? openXmlElement, DMDrawsChartDraws.GeoPolygons? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
