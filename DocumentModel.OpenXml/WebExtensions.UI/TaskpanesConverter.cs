namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public static class TaskpanesConverter
{
  private static Collection<DMWebExtUI.WebExtensionTaskpane> GetWebExtensionTaskpanes(DXO2013WebExtPane.Taskpanes openXmlElement)
  {
    var collection = new Collection<DMWebExtUI.WebExtensionTaskpane>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExtPane.WebExtensionTaskpane>())
    {
      var newItem = DMXWebExtUI.WebExtensionTaskpaneConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWebExtensionTaskpanes(DXO2013WebExtPane.Taskpanes openXmlElement, Collection<DMWebExtUI.WebExtensionTaskpane>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2013WebExtPane.WebExtensionTaskpane>();
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
        if (!DMXWebExtUI.WebExtensionTaskpaneConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMWebExtUI.Taskpanes? CreateModelElement(DXO2013WebExtPane.Taskpanes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExtUI.Taskpanes();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExtUI.Taskpanes? value)
    where OpenXmlElementType: DXO2013WebExtPane.Taskpanes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWebExtensionTaskpanes(openXmlElement, value?.WebExtensionTaskpanes);
      return openXmlElement;
    }
    return default;
  }
}
