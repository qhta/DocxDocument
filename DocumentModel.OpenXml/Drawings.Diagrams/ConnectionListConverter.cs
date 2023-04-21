namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public static class ConnectionListConverter
{
  private static Collection<DMDD.Connection>? GetConnections(DXDD.ConnectionList openXmlElement)
  {
    var collection = new Collection<DMDD.Connection>();
    foreach (var item in openXmlElement.Elements<DXDD.Connection>())
    {
      var newItem = DMXDD.ConnectionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpConnections(DXDD.ConnectionList openXmlElement, Collection<DMDD.Connection>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.Connection>();
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
        if (!DMXDD.ConnectionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetConnections(DXDD.ConnectionList openXmlElement, Collection<DMDD.Connection>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Connection>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ConnectionConverter.CreateOpenXmlElement<DXDD.Connection>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ConnectionList? CreateModelElement(DXDD.ConnectionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ConnectionList();
      value.Connections = GetConnections(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.ConnectionList? openXmlElement, DMDD.ConnectionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnections(openXmlElement, value.Connections, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ConnectionList value)
    where OpenXmlElementType: DXDD.ConnectionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ConnectionList openXmlElement, DMDD.ConnectionList value)
  {
    SetConnections(openXmlElement, value?.Connections);
  }
}
