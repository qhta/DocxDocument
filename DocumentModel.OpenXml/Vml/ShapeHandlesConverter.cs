using DocumentModel.Vml;
using ShapeHandles = DocumentFormat.OpenXml.Vml.ShapeHandles;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the ShapeHandles Class.
/// </summary>
public static class ShapeHandlesConverter
{
  public static Collection<ShapeHandle>? GetItems(ShapeHandles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ShapeHandle>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.ShapeHandle>())
      {
        var newItem = ShapeHandleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(ShapeHandles? openXmlElement, Collection<ShapeHandle>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.ShapeHandle>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ShapeHandleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ShapeHandle>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Vml.ShapeHandles? CreateModelElement(ShapeHandles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeHandles();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeHandles? value)
    where OpenXmlElementType : ShapeHandles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}