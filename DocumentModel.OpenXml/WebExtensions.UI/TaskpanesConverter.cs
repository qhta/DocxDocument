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
