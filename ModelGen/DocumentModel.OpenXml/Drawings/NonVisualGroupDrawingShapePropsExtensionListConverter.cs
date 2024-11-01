namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionListConverter
{
  private static Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>? GetNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualGroupDrawingShapePropsExtension>())
    {
      var newItem = DMXDraws.NonVisualGroupDrawingShapePropsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.NonVisualGroupDrawingShapePropsExtension>();
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
        if (!DMXDraws.NonVisualGroupDrawingShapePropsExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.NonVisualGroupDrawingShapePropsExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.NonVisualGroupDrawingShapePropsExtensionConverter.CreateOpenXmlElement<DXDraw.NonVisualGroupDrawingShapePropsExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? CreateModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList();
      value.NonVisualGroupDrawingShapePropsExtensions = GetNonVisualGroupDrawingShapePropsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value.NonVisualGroupDrawingShapePropsExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupDrawingShapePropsExtensionList value)
    where OpenXmlElementType: DXDraw.NonVisualGroupDrawingShapePropsExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtensionList value)
  {
    SetNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensions);
  }
}
