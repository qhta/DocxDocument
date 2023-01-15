using DocumentModel.Drawings;
using NonVisualPicturePropertiesExtensionList = DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionListConverter
{
  public static Collection<NonVisualPicturePropertiesExtension>? GetNonVisualPicturePropertiesExtensions(NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NonVisualPicturePropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>())
      {
        var newItem = NonVisualPicturePropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNonVisualPicturePropertiesExtensions(NonVisualPicturePropertiesExtensionList? openXmlElement, Collection<NonVisualPicturePropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NonVisualPicturePropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? CreateModelElement(NonVisualPicturePropertiesExtensionList? openXmlElement)
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
    where OpenXmlElementType : NonVisualPicturePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualPicturePropertiesExtensions(openXmlElement, value?.NonVisualPicturePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}