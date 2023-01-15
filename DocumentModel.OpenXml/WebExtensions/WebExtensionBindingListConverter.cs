using DocumentModel.WebExtensions;
using WebExtensionBindingList = DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList;

namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
///   Defines the WebExtensionBindingList Class.
/// </summary>
public static class WebExtensionBindingListConverter
{
  public static Collection<WebExtensionBinding>? GetWebExtensionBindings(WebExtensionBindingList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WebExtensionBinding>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>())
      {
        var newItem = WebExtensionBindingConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetWebExtensionBindings(WebExtensionBindingList? openXmlElement, Collection<WebExtensionBinding>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = WebExtensionBindingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.WebExtensions.WebExtensionBindingList? CreateModelElement(WebExtensionBindingList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionBindingList();
      value.WebExtensionBindings = GetWebExtensionBindings(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtensionBindingList? value)
    where OpenXmlElementType : WebExtensionBindingList, new()
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