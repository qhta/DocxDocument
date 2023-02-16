namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public static class GeoChildEntitiesConverter
{
  private static Collection<DMDrawsChartDraws.GeoHierarchyEntity>? GetGeoHierarchyEntities(DXO2016DrawChartDraw.GeoChildEntities openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoHierarchyEntity>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoHierarchyEntity>())
    {
      var newItem = DMXDrawsChartDraws.GeoHierarchyEntityConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpGeoHierarchyEntities(DXO2016DrawChartDraw.GeoChildEntities openXmlElement, Collection<DMDrawsChartDraws.GeoHierarchyEntity>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.GeoHierarchyEntity>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsChartDraws.GeoHierarchyEntityConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetGeoHierarchyEntities(DXO2016DrawChartDraw.GeoChildEntities openXmlElement, Collection<DMDrawsChartDraws.GeoHierarchyEntity>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoHierarchyEntity>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoHierarchyEntityConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoHierarchyEntity>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntities? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntities();
      value.GeoHierarchyEntities = GetGeoHierarchyEntities(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoChildEntities? openXmlElement, DMDrawsChartDraws.GeoChildEntities? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoHierarchyEntities(openXmlElement, value.GeoHierarchyEntities, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntities? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntities, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoHierarchyEntities(openXmlElement, value?.GeoHierarchyEntities);
      return openXmlElement;
    }
    return default;
  }
}
