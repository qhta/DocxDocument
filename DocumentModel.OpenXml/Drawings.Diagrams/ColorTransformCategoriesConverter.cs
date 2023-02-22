namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Category List.
/// </summary>
public static class ColorTransformCategoriesConverter
{
  private static Collection<DMDrawsDgms.ColorTransformCategory>? GetItems(DXDrawDgms.ColorTransformCategories openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorTransformCategory>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorTransformCategory>())
    {
      var newItem = DMXDrawsDgms.ColorTransformCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDrawDgms.ColorTransformCategories openXmlElement, Collection<DMDrawsDgms.ColorTransformCategory>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.ColorTransformCategory>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!DMXDrawsDgms.ColorTransformCategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformCategories? CreateModelElement(DXDrawDgms.ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformCategories();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformCategories value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformCategories, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ColorTransformCategories openXmlElement, DMDrawsDgms.ColorTransformCategories value)
  {
    SetItems(openXmlElement, value?.Items);
    }
  }
