using DocumentModel.WebExtensions;
using WebExtensionPropertyBag = DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag;

namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
///   Defines the WebExtensionPropertyBag Class.
/// </summary>
public static class WebExtensionPropertyBagConverter
{
  public static Collection<WebExtensionProperty>? GetWebExtensionProperties(WebExtensionPropertyBag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WebExtensionProperty>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>())
      {
        var newItem = WebExtensionPropertyConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetWebExtensionProperties(WebExtensionPropertyBag? openXmlElement, Collection<WebExtensionProperty>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = WebExtensionPropertyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.WebExtensions.WebExtensionPropertyBag? CreateModelElement(WebExtensionPropertyBag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionPropertyBag();
      value.WebExtensionProperties = GetWebExtensionProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtensionPropertyBag? value)
    where OpenXmlElementType : WebExtensionPropertyBag, new()
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