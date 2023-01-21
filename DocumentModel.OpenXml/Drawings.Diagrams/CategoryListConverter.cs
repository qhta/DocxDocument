namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class CategoryListConverter
{
  private static Collection<DMDrawsDgms.Category> GetCategories(DXDrawDgms.CategoryList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Category>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Category>())
    {
      var newItem = DMXDrawsDgms.CategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetCategories(DXDrawDgms.CategoryList openXmlElement, Collection<DMDrawsDgms.Category>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Category>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.CategoryConverter.CreateOpenXmlElement<DXDrawDgms.Category>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.CategoryList? CreateModelElement(DXDrawDgms.CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.CategoryList();
      value.Categories = GetCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.CategoryList? value)
    where OpenXmlElementType: DXDrawDgms.CategoryList, new()
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
