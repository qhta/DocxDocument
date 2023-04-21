namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public static class PathListConverter
{
  private static Collection<DMD.Path>? GetPaths(DXD.PathList openXmlElement)
  {
    var collection = new Collection<DMD.Path>();
    foreach (var item in openXmlElement.Elements<DXD.Path>())
    {
      var newItem = DMXD.PathConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPaths(DXD.PathList openXmlElement, Collection<DMD.Path>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.Path>();
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
        if (!DMXD.PathConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPaths(DXD.PathList openXmlElement, Collection<DMD.Path>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.Path>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.PathConverter.CreateOpenXmlElement<DXD.Path>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.PathList? CreateModelElement(DXD.PathList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PathList();
      value.Paths = GetPaths(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PathList? openXmlElement, DMD.PathList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPaths(openXmlElement, value.Paths, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PathList value)
    where OpenXmlElementType: DXD.PathList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PathList openXmlElement, DMD.PathList value)
  {
    SetPaths(openXmlElement, value?.Paths);
  }
}
