namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Category List.
/// </summary>
public static class ColorTransformCategoriesConverter
{
  private static Collection<DMDD.ColorTransformCategory>? GetItems(DXDD.ColorTransformCategories openXmlElement)
  {
    var collection = new Collection<DMDD.ColorTransformCategory>();
    foreach (var item in openXmlElement.Elements<DXDD.ColorTransformCategory>())
    {
      var newItem = DMXDD.ColorTransformCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDD.ColorTransformCategories openXmlElement, Collection<DMDD.ColorTransformCategory>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.ColorTransformCategory>();
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
        if (!DMXDD.ColorTransformCategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDD.ColorTransformCategories openXmlElement, Collection<DMDD.ColorTransformCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.ColorTransformCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ColorTransformCategoryConverter.CreateOpenXmlElement<DXDD.ColorTransformCategory>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformCategories? CreateModelElement(DXDD.ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.ColorTransformCategories? openXmlElement, DMDD.ColorTransformCategories? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ColorTransformCategories value)
    where OpenXmlElementType: DXDD.ColorTransformCategories, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ColorTransformCategories openXmlElement, DMDD.ColorTransformCategories value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
