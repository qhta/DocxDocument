namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public static class GeoChildEntitiesConverter
{
  private static Collection<DMDrawsChartDraws.GeoHierarchyEntity> GetGeoHierarchyEntities(DXO2016DrawChartDraw.GeoChildEntities openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoHierarchyEntity>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoHierarchyEntity>())
    {
      var newItem = DMXDrawsChartDraws.GeoHierarchyEntityConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpGeoHierarchyEntities(DXO2016DrawChartDraw.GeoChildEntities openXmlElement, Collection<DMDrawsChartDraws.GeoHierarchyEntity>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static DMDrawsChartDraws.GeoChildEntities? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoChildEntities();
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
    return openXmlElement == null && value == null;
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
