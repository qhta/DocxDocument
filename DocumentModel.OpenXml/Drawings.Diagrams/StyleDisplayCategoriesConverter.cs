using DocumentModel.Drawings.Diagrams;
using StyleDisplayCategories = DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Category List.
/// </summary>
public static class StyleDisplayCategoriesConverter
{
  public static Collection<StyleDisplayCategory>? GetItems(StyleDisplayCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StyleDisplayCategory>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>())
      {
        var newItem = StyleDisplayCategoryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(StyleDisplayCategories? openXmlElement, Collection<StyleDisplayCategory>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StyleDisplayCategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategories? CreateModelElement(StyleDisplayCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDisplayCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDisplayCategories? value)
    where OpenXmlElementType : StyleDisplayCategories, new()
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