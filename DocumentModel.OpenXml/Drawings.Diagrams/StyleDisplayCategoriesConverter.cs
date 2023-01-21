namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class StyleDisplayCategoriesConverter
{
  private static Collection<DMDrawsDgms.StyleDisplayCategory> GetItems(DXDrawDgms.StyleDisplayCategories openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.StyleDisplayCategory>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.StyleDisplayCategory>())
    {
      var newItem = DMXDrawsDgms.StyleDisplayCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXDrawDgms.StyleDisplayCategories openXmlElement, Collection<DMDrawsDgms.StyleDisplayCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.StyleDisplayCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.StyleDisplayCategoryConverter.CreateOpenXmlElement<DXDrawDgms.StyleDisplayCategory>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.StyleDisplayCategories? CreateModelElement(DXDrawDgms.StyleDisplayCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleDisplayCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleDisplayCategories? value)
    where OpenXmlElementType: DXDrawDgms.StyleDisplayCategories, new()
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
