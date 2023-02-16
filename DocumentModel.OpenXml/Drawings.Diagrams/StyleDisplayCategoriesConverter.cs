namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class StyleDisplayCategoriesConverter
{
  private static Collection<DMDrawsDgms.StyleDisplayCategory>? GetItems(DXDrawDgms.StyleDisplayCategories openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.StyleDisplayCategory>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.StyleDisplayCategory>())
    {
      var newItem = DMXDrawsDgms.StyleDisplayCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDrawDgms.StyleDisplayCategories openXmlElement, Collection<DMDrawsDgms.StyleDisplayCategory>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.StyleDisplayCategory>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsDgms.StyleDisplayCategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
  
  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategories? CreateModelElement(DXDrawDgms.StyleDisplayCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDisplayCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.StyleDisplayCategories? openXmlElement, DMDrawsDgms.StyleDisplayCategories? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
