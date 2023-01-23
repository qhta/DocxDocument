namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Category List.
/// </summary>
public static class ColorTransformCategoriesConverter
{
  private static Collection<DMDrawsDgms.ColorTransformCategory> GetItems(DXDrawDgms.ColorTransformCategories openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorTransformCategory>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorTransformCategory>())
    {
      var newItem = DMXDrawsDgms.ColorTransformCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXDrawDgms.ColorTransformCategories openXmlElement, Collection<DMDrawsDgms.ColorTransformCategory>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXDrawDgms.ColorTransformCategories openXmlElement, Collection<DMDrawsDgms.ColorTransformCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.ColorTransformCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ColorTransformCategoryConverter.CreateOpenXmlElement<DXDrawDgms.ColorTransformCategory>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.ColorTransformCategories? CreateModelElement(DXDrawDgms.ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorTransformCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ColorTransformCategories? openXmlElement, DMDrawsDgms.ColorTransformCategories? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformCategories? value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformCategories, new()
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
