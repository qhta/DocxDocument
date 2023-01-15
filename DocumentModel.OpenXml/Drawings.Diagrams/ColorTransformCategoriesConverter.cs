using DocumentModel.Drawings.Diagrams;
using ColorTransformCategories = DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Color Transform Category List.
/// </summary>
public static class ColorTransformCategoriesConverter
{
  public static Collection<ColorTransformCategory>? GetItems(ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ColorTransformCategory>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>())
      {
        var newItem = ColorTransformCategoryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(ColorTransformCategories? openXmlElement, Collection<ColorTransformCategory>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ColorTransformCategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ColorTransformCategories? CreateModelElement(ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorTransformCategories? value)
    where OpenXmlElementType : ColorTransformCategories, new()
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