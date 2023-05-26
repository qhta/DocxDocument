namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public static class TaskpanesConverter
{
  private static Collection<DMWEUI.WebExtensionTaskpane>? GetWebExtensionTaskpanes(DXO13WEP.Taskpanes openXmlElement)
  {
    var collection = new Collection<DMWEUI.WebExtensionTaskpane>();
    foreach (var item in openXmlElement.Elements<DXO13WEP.WebExtensionTaskpane>())
    {
      var newItem = DMXWEUI.WebExtensionTaskpaneConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionTaskpanes(DXO13WEP.Taskpanes openXmlElement, Collection<DMWEUI.WebExtensionTaskpane>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO13WEP.WebExtensionTaskpane>();
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
        if (!DMXWEUI.WebExtensionTaskpaneConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionTaskpanes(DXO13WEP.Taskpanes openXmlElement, Collection<DMWEUI.WebExtensionTaskpane>? value)
  {
    openXmlElement.RemoveAllChildren<DXO13WEP.WebExtensionTaskpane>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWEUI.WebExtensionTaskpaneConverter.CreateOpenXmlElement<DXO13WEP.WebExtensionTaskpane>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.UI.Taskpanes? CreateModelElement(DXO13WEP.Taskpanes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.Taskpanes();
      value.WebExtensionTaskpanes = GetWebExtensionTaskpanes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13WEP.Taskpanes? openXmlElement, DMWEUI.Taskpanes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionTaskpanes(openXmlElement, value.WebExtensionTaskpanes, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWEUI.Taskpanes value)
    where OpenXmlElementType: DXO13WEP.Taskpanes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WEP.Taskpanes openXmlElement, DMWEUI.Taskpanes value)
  {
    SetWebExtensionTaskpanes(openXmlElement, value?.WebExtensionTaskpanes);
  }
}
