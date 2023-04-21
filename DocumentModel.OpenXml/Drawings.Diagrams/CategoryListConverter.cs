namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class CategoryListConverter
{
  private static Collection<DMDD.Category>? GetCategories(DXDD.CategoryList openXmlElement)
  {
    var collection = new Collection<DMDD.Category>();
    foreach (var item in openXmlElement.Elements<DXDD.Category>())
    {
      var newItem = DMXDD.CategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCategories(DXDD.CategoryList openXmlElement, Collection<DMDD.Category>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.Category>();
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
        if (!DMXDD.CategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCategories(DXDD.CategoryList openXmlElement, Collection<DMDD.Category>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Category>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.CategoryConverter.CreateOpenXmlElement<DXDD.Category>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.CategoryList? CreateModelElement(DXDD.CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.CategoryList();
      value.Categories = GetCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.CategoryList? openXmlElement, DMDD.CategoryList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCategories(openXmlElement, value.Categories, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.CategoryList value)
    where OpenXmlElementType: DXDD.CategoryList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.CategoryList openXmlElement, DMDD.CategoryList value)
  {
    SetCategories(openXmlElement, value?.Categories);
  }
}
