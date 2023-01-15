using DocumentModel.Drawings;
using NonVisualDrawingPropertiesExtensionList = DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionListConverter
{
  public static Collection<NonVisualDrawingPropertiesExtension>? GetNonVisualDrawingPropertiesExtensions(NonVisualDrawingPropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NonVisualDrawingPropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>())
      {
        var newItem = NonVisualDrawingPropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNonVisualDrawingPropertiesExtensions(NonVisualDrawingPropertiesExtensionList? openXmlElement, Collection<NonVisualDrawingPropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NonVisualDrawingPropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? CreateModelElement(NonVisualDrawingPropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList();
      value.NonVisualDrawingPropertiesExtensions = GetNonVisualDrawingPropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? value)
    where OpenXmlElementType : NonVisualDrawingPropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingPropertiesExtensions(openXmlElement, value?.NonVisualDrawingPropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}