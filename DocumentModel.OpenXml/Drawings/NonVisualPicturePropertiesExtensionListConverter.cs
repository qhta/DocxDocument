namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>? GetNonVisualPicturePropertiesExtensions(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.NonVisualPicturePropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetNonVisualPicturePropertiesExtensions(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.NonVisualPicturePropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList();
      value.NonVisualPicturePropertiesExtensions = GetNonVisualPicturePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
