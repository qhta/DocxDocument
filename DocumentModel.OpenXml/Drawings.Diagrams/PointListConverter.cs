namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public static class PointListConverter
{
  private static Collection<DMDD.Point>? GetPoints(DXDD.PointList openXmlElement)
  {
    var collection = new Collection<DMDD.Point>();
    foreach (var item in openXmlElement.Elements<DXDD.Point>())
    {
      var newItem = DMXDD.PointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPoints(DXDD.PointList openXmlElement, Collection<DMDD.Point>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.Point>();
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
        if (!DMXDD.PointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPoints(DXDD.PointList openXmlElement, Collection<DMDD.Point>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Point>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.PointConverter.CreateOpenXmlElement<DXDD.Point>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PointList? CreateModelElement(DXDD.PointList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PointList();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.PointList? openXmlElement, DMDD.PointList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPoints(openXmlElement, value.Points, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.PointList value)
    where OpenXmlElementType: DXDD.PointList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.PointList openXmlElement, DMDD.PointList value)
  {
    SetPoints(openXmlElement, value?.Points);
  }
}
