namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public static class WebExtensionBindingListConverter
{
  private static Collection<DMWebExt.WebExtensionBinding> GetWebExtensionBindings(DXO2013WebExt.WebExtensionBindingList openXmlElement)
  {
    var collection = new Collection<DMWebExt.WebExtensionBinding>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExt.WebExtensionBinding>())
    {
      var newItem = DMXWebExt.WebExtensionBindingConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWebExtensionBindings(DXO2013WebExt.WebExtensionBindingList openXmlElement, Collection<DMWebExt.WebExtensionBinding>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetWebExtensionBindings(DXO2013WebExt.WebExtensionBindingList openXmlElement, Collection<DMWebExt.WebExtensionBinding>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExt.WebExtensionBinding>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExt.WebExtensionBindingConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionBinding>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMWebExt.WebExtensionBindingList? CreateModelElement(DXO2013WebExt.WebExtensionBindingList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionBindingList();
      value.WebExtensionBindings = GetWebExtensionBindings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionBindingList? openXmlElement, DMWebExt.WebExtensionBindingList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionBindings(openXmlElement, value.WebExtensionBindings, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionBindingList? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionBindingList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWebExtensionBindings(openXmlElement, value?.WebExtensionBindings);
      return openXmlElement;
    }
    return default;
  }
}
