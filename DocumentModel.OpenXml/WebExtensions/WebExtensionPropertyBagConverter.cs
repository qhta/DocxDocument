namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public static class WebExtensionPropertyBagConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionProperty>? GetWebExtensionProperties(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionProperty>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>())
      {
        var newItem = DocumentModel.OpenXml.WebExtensions.WebExtensionPropertyConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetWebExtensionProperties(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.WebExtensionProperty>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.WebExtensions.WebExtensionPropertyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionPropertyBag? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
