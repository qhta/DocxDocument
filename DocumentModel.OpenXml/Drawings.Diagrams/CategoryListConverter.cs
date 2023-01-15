using DocumentModel.Drawings.Diagrams;
using CategoryList = DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Category List.
/// </summary>
public static class CategoryListConverter
{
  public static Collection<Category>? GetCategories(CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Category>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Category>())
      {
        var newItem = CategoryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCategories(CategoryList? openXmlElement, Collection<Category>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Category>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Category>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.CategoryList? CreateModelElement(CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.CategoryList();
      value.Categories = GetCategories(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.CategoryList? value)
    where OpenXmlElementType : CategoryList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCategories(openXmlElement, value?.Categories);
      return openXmlElement;
    }
    return default;
  }
}