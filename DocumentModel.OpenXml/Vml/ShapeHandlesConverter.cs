namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the ShapeHandles Class.
/// </summary>
public static class ShapeHandlesConverter
{
  private static Collection<DMV.ShapeHandle>? GetItems(DXV.ShapeHandles openXmlElement)
  {
    var collection = new Collection<DMV.ShapeHandle>();
    foreach (var item in openXmlElement.Elements<DXV.ShapeHandle>())
    {
      var newItem = DMXV.ShapeHandleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXV.ShapeHandles openXmlElement, Collection<DMV.ShapeHandle>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXV.ShapeHandle>();
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
        if (!DMXV.ShapeHandleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXV.ShapeHandles openXmlElement, Collection<DMV.ShapeHandle>? value)
  {
    openXmlElement.RemoveAllChildren<DXV.ShapeHandle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXV.ShapeHandleConverter.CreateOpenXmlElement<DXV.ShapeHandle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.ShapeHandles? CreateModelElement(DXV.ShapeHandles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeHandles();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.ShapeHandles? openXmlElement, DMV.ShapeHandles? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.ShapeHandles value)
    where OpenXmlElementType: DXV.ShapeHandles, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.ShapeHandles openXmlElement, DMV.ShapeHandles value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
