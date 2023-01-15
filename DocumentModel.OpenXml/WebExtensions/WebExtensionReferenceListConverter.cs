using DocumentModel.WebExtensions;
using WebExtensionReferenceList = DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList;

namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
///   Defines the WebExtensionReferenceList Class.
/// </summary>
public static class WebExtensionReferenceListConverter
{
  public static Collection<WebExtensionStoreReference>? GetWebExtensionStoreReferences(WebExtensionReferenceList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WebExtensionStoreReference>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>())
      {
        var newItem = WebExtensionStoreReferenceConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetWebExtensionStoreReferences(WebExtensionReferenceList? openXmlElement, Collection<WebExtensionStoreReference>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.WebExtensions.WebExtensionReferenceList? CreateModelElement(WebExtensionReferenceList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionReferenceList();
      value.WebExtensionStoreReferences = GetWebExtensionStoreReferences(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtensionReferenceList? value)
    where OpenXmlElementType : WebExtensionReferenceList, new()
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