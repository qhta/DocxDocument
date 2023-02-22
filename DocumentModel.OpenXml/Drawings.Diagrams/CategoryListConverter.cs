namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class CategoryListConverter
{
  private static Collection<DMDrawsDgms.Category>? GetCategories(DXDrawDgms.CategoryList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Category>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Category>())
    {
      var newItem = DMXDrawsDgms.CategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCategories(DXDrawDgms.CategoryList openXmlElement, Collection<DMDrawsDgms.Category>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Category>();
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
        if (!DMXDrawsDgms.CategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
  
  public static DocumentModel.Drawings.Diagrams.CategoryList? CreateModelElement(DXDrawDgms.CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.CategoryList();
      value.Categories = GetCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.CategoryList? openXmlElement, DMDrawsDgms.CategoryList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.CategoryList value)
    where OpenXmlElementType: DXDrawDgms.CategoryList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.CategoryList openXmlElement, DMDrawsDgms.CategoryList value)
  {
    SetCategories(openXmlElement, value?.Categories);
    }
  }
