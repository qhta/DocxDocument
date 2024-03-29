namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public static class TaskpanesConverter
{
  private static Collection<DMWebExtUI.WebExtensionTaskpane>? GetWebExtensionTaskpanes(DXO2013WebExtPane.Taskpanes openXmlElement)
  {
    var collection = new Collection<DMWebExtUI.WebExtensionTaskpane>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExtPane.WebExtensionTaskpane>())
    {
      var newItem = DMXWebExtUI.WebExtensionTaskpaneConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionTaskpanes(DXO2013WebExtPane.Taskpanes openXmlElement, Collection<DMWebExtUI.WebExtensionTaskpane>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2013WebExtPane.WebExtensionTaskpane>();
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
        if (!DMXWebExtUI.WebExtensionTaskpaneConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionTaskpanes(DXO2013WebExtPane.Taskpanes openXmlElement, Collection<DMWebExtUI.WebExtensionTaskpane>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExtPane.WebExtensionTaskpane>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExtUI.WebExtensionTaskpaneConverter.CreateOpenXmlElement<DXO2013WebExtPane.WebExtensionTaskpane>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.UI.Taskpanes? CreateModelElement(DXO2013WebExtPane.Taskpanes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.Taskpanes();
      value.WebExtensionTaskpanes = GetWebExtensionTaskpanes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExtPane.Taskpanes? openXmlElement, DMWebExtUI.Taskpanes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionTaskpanes(openXmlElement, value.WebExtensionTaskpanes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExtUI.Taskpanes value)
    where OpenXmlElementType: DXO2013WebExtPane.Taskpanes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExtPane.Taskpanes openXmlElement, DMWebExtUI.Taskpanes value)
  {
    SetWebExtensionTaskpanes(openXmlElement, value?.WebExtensionTaskpanes);
  }
}
