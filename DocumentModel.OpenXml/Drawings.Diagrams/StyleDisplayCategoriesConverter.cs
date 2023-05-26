namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class StyleDisplayCategoriesConverter
{
  private static Collection<DMDD.StyleDisplayCategory>? GetItems(DXDD.StyleDisplayCategories openXmlElement)
  {
    var collection = new Collection<DMDD.StyleDisplayCategory>();
    foreach (var item in openXmlElement.Elements<DXDD.StyleDisplayCategory>())
    {
      var newItem = DMXDD.StyleDisplayCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDD.StyleDisplayCategories openXmlElement, Collection<DMDD.StyleDisplayCategory>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.StyleDisplayCategory>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDD.StyleDisplayCategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDD.StyleDisplayCategories openXmlElement, Collection<DMDD.StyleDisplayCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.StyleDisplayCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.StyleDisplayCategoryConverter.CreateOpenXmlElement<DXDD.StyleDisplayCategory>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategories? CreateModelElement(DXDD.StyleDisplayCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDisplayCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.StyleDisplayCategories? openXmlElement, DMDD.StyleDisplayCategories? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.StyleDisplayCategories value)
    where OpenXmlElementType: DXDD.StyleDisplayCategories, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.StyleDisplayCategories openXmlElement, DMDD.StyleDisplayCategories value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
