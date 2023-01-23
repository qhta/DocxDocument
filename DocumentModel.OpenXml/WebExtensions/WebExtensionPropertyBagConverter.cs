namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public static class WebExtensionPropertyBagConverter
{
  private static Collection<DMWebExt.WebExtensionProperty> GetWebExtensionProperties(DXO2013WebExt.WebExtensionPropertyBag openXmlElement)
  {
    var collection = new Collection<DMWebExt.WebExtensionProperty>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExt.WebExtensionProperty>())
    {
      var newItem = DMXWebExt.WebExtensionPropertyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWebExtensionProperties(DXO2013WebExt.WebExtensionPropertyBag openXmlElement, Collection<DMWebExt.WebExtensionProperty>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetWebExtensionProperties(DXO2013WebExt.WebExtensionPropertyBag openXmlElement, Collection<DMWebExt.WebExtensionProperty>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExt.WebExtensionProperty>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExt.WebExtensionPropertyConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionProperty>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMWebExt.WebExtensionPropertyBag? CreateModelElement(DXO2013WebExt.WebExtensionPropertyBag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionPropertyBag();
      value.WebExtensionProperties = GetWebExtensionProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionPropertyBag? openXmlElement, DMWebExt.WebExtensionPropertyBag? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionProperties(openXmlElement, value.WebExtensionProperties, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionPropertyBag? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionPropertyBag, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWebExtensionProperties(openXmlElement, value?.WebExtensionProperties);
      return openXmlElement;
    }
    return default;
  }
}
