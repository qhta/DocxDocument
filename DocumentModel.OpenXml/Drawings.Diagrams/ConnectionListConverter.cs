namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public static class ConnectionListConverter
{
  private static Collection<DMDrawsDgms.Connection>? GetConnections(DXDrawDgms.ConnectionList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Connection>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Connection>())
    {
      var newItem = DMXDrawsDgms.ConnectionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpConnections(DXDrawDgms.ConnectionList openXmlElement, Collection<DMDrawsDgms.Connection>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Connection>();
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
        if (!DMXDrawsDgms.ConnectionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetConnections(DXDrawDgms.ConnectionList openXmlElement, Collection<DMDrawsDgms.Connection>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Connection>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ConnectionConverter.CreateOpenXmlElement<DXDrawDgms.Connection>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ConnectionList? CreateModelElement(DXDrawDgms.ConnectionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ConnectionList();
      value.Connections = GetConnections(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ConnectionList? openXmlElement, DMDrawsDgms.ConnectionList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ConnectionList value)
    where OpenXmlElementType: DXDrawDgms.ConnectionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ConnectionList openXmlElement, DMDrawsDgms.ConnectionList value)
  {
    SetConnections(openXmlElement, value?.Connections);
  }
}
