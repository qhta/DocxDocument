namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public static class WebExtensionBindingListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionBinding>? GetWebExtensionBindings(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionBinding>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>())
      {
        var newItem = DocumentModel.OpenXml.WebExtensions.WebExtensionBindingConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetWebExtensionBindings(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionBinding>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.WebExtensions.WebExtensionBindingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionBindingList? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
