namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public static class GeoChildEntitiesConverter
{
  private static Collection<DMDCDs.GeoHierarchyEntity>? GetGeoHierarchyEntities(DXO16DCD.GeoChildEntities openXmlElement)
  {
    var collection = new Collection<DMDCDs.GeoHierarchyEntity>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.GeoHierarchyEntity>())
    {
      var newItem = DMXDCDs.GeoHierarchyEntityConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpGeoHierarchyEntities(DXO16DCD.GeoChildEntities openXmlElement, Collection<DMDCDs.GeoHierarchyEntity>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.GeoHierarchyEntity>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.GeoHierarchyEntityConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetGeoHierarchyEntities(DXO16DCD.GeoChildEntities openXmlElement, Collection<DMDCDs.GeoHierarchyEntity>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.GeoHierarchyEntity>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.GeoHierarchyEntityConverter.CreateOpenXmlElement<DXO16DCD.GeoHierarchyEntity>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDCDs.GeoChildEntities? CreateModelElement(DXO16DCD.GeoChildEntities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoChildEntities();
      value.GeoHierarchyEntities = GetGeoHierarchyEntities(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoChildEntities? openXmlElement, DMDCDs.GeoChildEntities? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoHierarchyEntities(openXmlElement, value.GeoHierarchyEntities, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoChildEntities value)
    where OpenXmlElementType: DXO16DCD.GeoChildEntities, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoChildEntities openXmlElement, DMDCDs.GeoChildEntities value)
  {
    SetGeoHierarchyEntities(openXmlElement, value?.GeoHierarchyEntities);
  }
}
