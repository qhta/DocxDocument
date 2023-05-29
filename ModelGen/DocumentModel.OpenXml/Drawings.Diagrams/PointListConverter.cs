namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public static class PointListConverter
{
  private static Collection<DMDrawsDgms.Point>? GetPoints(DXDrawDgms.PointList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Point>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Point>())
    {
      var newItem = DMXDrawsDgms.PointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPoints(DXDrawDgms.PointList openXmlElement, Collection<DMDrawsDgms.Point>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Point>();
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
        if (!DMXDrawsDgms.PointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPoints(DXDrawDgms.PointList openXmlElement, Collection<DMDrawsDgms.Point>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Point>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.PointConverter.CreateOpenXmlElement<DXDrawDgms.Point>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PointList? CreateModelElement(DXDrawDgms.PointList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PointList();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.PointList? openXmlElement, DMDrawsDgms.PointList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PointList value)
    where OpenXmlElementType: DXDrawDgms.PointList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.PointList openXmlElement, DMDrawsDgms.PointList value)
  {
    SetPoints(openXmlElement, value?.Points);
  }
}
