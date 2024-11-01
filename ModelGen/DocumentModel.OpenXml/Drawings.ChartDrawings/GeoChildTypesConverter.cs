namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildTypes Class.
/// </summary>
public static class GeoChildTypesConverter
{
  private static Collection<String>? GetEntityTypes(DXO2016DrawChartDraw.GeoChildTypes openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.EntityType>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpEntityTypes(DXO2016DrawChartDraw.GeoChildTypes openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.EntityType>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!StringValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetEntityTypes(DXO2016DrawChartDraw.GeoChildTypes openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.EntityType>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.EntityType>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildTypes? CreateModelElement(DXO2016DrawChartDraw.GeoChildTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildTypes();
      value.EntityTypes = GetEntityTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoChildTypes? openXmlElement, DMDrawsChartDraws.GeoChildTypes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityTypes(openXmlElement, value.EntityTypes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildTypes value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildTypes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoChildTypes openXmlElement, DMDrawsChartDraws.GeoChildTypes value)
  {
    SetEntityTypes(openXmlElement, value?.EntityTypes);
  }
}
