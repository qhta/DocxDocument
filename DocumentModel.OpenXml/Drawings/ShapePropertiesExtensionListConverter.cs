using DocumentModel.Drawings;
using ShapePropertiesExtensionList = DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ShapePropertiesExtensionList Class.
/// </summary>
public static class ShapePropertiesExtensionListConverter
{
  public static Collection<ShapePropertiesExtension>? GetShapePropertiesExtensions(ShapePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ShapePropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>())
      {
        var newItem = ShapePropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetShapePropertiesExtensions(ShapePropertiesExtensionList? openXmlElement, Collection<ShapePropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ShapePropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ShapePropertiesExtensionList? CreateModelElement(ShapePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapePropertiesExtensionList();
      value.ShapePropertiesExtensions = GetShapePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapePropertiesExtensionList? value)
    where OpenXmlElementType : ShapePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapePropertiesExtensions(openXmlElement, value?.ShapePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}