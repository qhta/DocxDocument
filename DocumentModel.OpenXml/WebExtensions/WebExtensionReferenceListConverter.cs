namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public static class WebExtensionReferenceListConverter
{
  private static Collection<DMWebExt.WebExtensionStoreReference> GetWebExtensionStoreReferences(DXO2013WebExt.WebExtensionReferenceList openXmlElement)
  {
    var collection = new Collection<DMWebExt.WebExtensionStoreReference>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExt.WebExtensionStoreReference>())
    {
      var newItem = DMXWebExt.WebExtensionStoreReferenceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetWebExtensionStoreReferences(DXO2013WebExt.WebExtensionReferenceList openXmlElement, Collection<DMWebExt.WebExtensionStoreReference>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExt.WebExtensionStoreReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExt.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionStoreReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMWebExt.WebExtensionReferenceList? CreateModelElement(DXO2013WebExt.WebExtensionReferenceList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionReferenceList();
      value.WebExtensionStoreReferences = GetWebExtensionStoreReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionReferenceList? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionReferenceList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWebExtensionStoreReferences(openXmlElement, value?.WebExtensionStoreReferences);
      return openXmlElement;
    }
    return default;
  }
}
