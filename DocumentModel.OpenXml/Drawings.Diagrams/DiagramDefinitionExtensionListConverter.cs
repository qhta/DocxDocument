namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public static class DiagramDefinitionExtensionListConverter
{
  private static Collection<DMDrawsDgms.DiagramDefinitionExtension> GetDiagramDefinitionExtensions(DXDrawDgms.DiagramDefinitionExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.DiagramDefinitionExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.DiagramDefinitionExtension>())
    {
      var newItem = DMXDrawsDgms.DiagramDefinitionExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDiagramDefinitionExtensions(DXDrawDgms.DiagramDefinitionExtensionList openXmlElement, Collection<DMDrawsDgms.DiagramDefinitionExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.DiagramDefinitionExtension>();
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
        if (!DMXDrawsDgms.DiagramDefinitionExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDiagramDefinitionExtensions(DXDrawDgms.DiagramDefinitionExtensionList openXmlElement, Collection<DMDrawsDgms.DiagramDefinitionExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.DiagramDefinitionExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.DiagramDefinitionExtensionConverter.CreateOpenXmlElement<DXDrawDgms.DiagramDefinitionExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.DiagramDefinitionExtensionList? CreateModelElement(DXDrawDgms.DiagramDefinitionExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DiagramDefinitionExtensionList();
      value.DiagramDefinitionExtensions = GetDiagramDefinitionExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.DiagramDefinitionExtensionList? openXmlElement, DMDrawsDgms.DiagramDefinitionExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDiagramDefinitionExtensions(openXmlElement, value.DiagramDefinitionExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DiagramDefinitionExtensionList? value)
    where OpenXmlElementType: DXDrawDgms.DiagramDefinitionExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDiagramDefinitionExtensions(openXmlElement, value?.DiagramDefinitionExtensions);
      return openXmlElement;
    }
    return default;
  }
}
