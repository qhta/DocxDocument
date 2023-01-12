namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public static class WebExtensionReferenceListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionStoreReference>? GetWebExtensionStoreReferences(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionStoreReference>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>())
      {
        var newItem = DocumentModel.OpenXml.WebExtensions.WebExtensionStoreReferenceConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetWebExtensionStoreReferences(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionStoreReference>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.WebExtensions.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionReferenceList? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
