namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public static class PathListConverter
{
  private static Collection<DMDraws.Path> GetPaths(DXDraw.PathList openXmlElement)
  {
    var collection = new Collection<DMDraws.Path>();
    foreach (var item in openXmlElement.Elements<DXDraw.Path>())
    {
      var newItem = DMXDraws.PathConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPaths(DXDraw.PathList openXmlElement, Collection<DMDraws.Path>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetPaths(DXDraw.PathList openXmlElement, Collection<DMDraws.Path>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.Path>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.PathConverter.CreateOpenXmlElement<DXDraw.Path>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.PathList? CreateModelElement(DXDraw.PathList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PathList();
      value.Paths = GetPaths(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PathList? openXmlElement, DMDraws.PathList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPaths(openXmlElement, value.Paths, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PathList? value)
    where OpenXmlElementType: DXDraw.PathList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPaths(openXmlElement, value?.Paths);
      return openXmlElement;
    }
    return default;
  }
}
