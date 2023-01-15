using DocumentModel.Drawings;
using NonVisualGroupDrawingShapePropsExtensionList = DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionListConverter
{
  public static Collection<NonVisualGroupDrawingShapePropsExtension>? GetNonVisualGroupDrawingShapePropsExtensions(NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NonVisualGroupDrawingShapePropsExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>())
      {
        var newItem = NonVisualGroupDrawingShapePropsExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNonVisualGroupDrawingShapePropsExtensions(NonVisualGroupDrawingShapePropsExtensionList? openXmlElement, Collection<NonVisualGroupDrawingShapePropsExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NonVisualGroupDrawingShapePropsExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? CreateModelElement(NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList();
      value.NonVisualGroupDrawingShapePropsExtensions = GetNonVisualGroupDrawingShapePropsExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? value)
    where OpenXmlElementType : NonVisualGroupDrawingShapePropsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensions);
      return openXmlElement;
    }
    return default;
  }
}