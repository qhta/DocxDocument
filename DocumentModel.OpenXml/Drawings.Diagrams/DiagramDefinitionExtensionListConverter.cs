namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public static class DiagramDefinitionExtensionListConverter
{
  private static Collection<DMDD.DiagramDefinitionExtension>? GetDiagramDefinitionExtensions(DXDD.DiagramDefinitionExtensionList openXmlElement)
  {
    var collection = new Collection<DMDD.DiagramDefinitionExtension>();
    foreach (var item in openXmlElement.Elements<DXDD.DiagramDefinitionExtension>())
    {
      var newItem = DMXDD.DiagramDefinitionExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDiagramDefinitionExtensions(DXDD.DiagramDefinitionExtensionList openXmlElement, Collection<DMDD.DiagramDefinitionExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.DiagramDefinitionExtension>();
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
        if (!DMXDD.DiagramDefinitionExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDiagramDefinitionExtensions(DXDD.DiagramDefinitionExtensionList openXmlElement, Collection<DMDD.DiagramDefinitionExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.DiagramDefinitionExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.DiagramDefinitionExtensionConverter.CreateOpenXmlElement<DXDD.DiagramDefinitionExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDD.DiagramDefinitionExtensionList? CreateModelElement(DXDD.DiagramDefinitionExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.DiagramDefinitionExtensionList();
      value.DiagramDefinitionExtensions = GetDiagramDefinitionExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.DiagramDefinitionExtensionList? openXmlElement, DMDD.DiagramDefinitionExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDiagramDefinitionExtensions(openXmlElement, value.DiagramDefinitionExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DiagramDefinitionExtensionList value)
    where OpenXmlElementType: DXDD.DiagramDefinitionExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DiagramDefinitionExtensionList openXmlElement, DMDD.DiagramDefinitionExtensionList value)
  {
    SetDiagramDefinitionExtensions(openXmlElement, value?.DiagramDefinitionExtensions);
  }
}
