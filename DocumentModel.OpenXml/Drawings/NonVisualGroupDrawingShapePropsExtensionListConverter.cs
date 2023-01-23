namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionListConverter
{
  private static Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension> GetNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualGroupDrawingShapePropsExtension>())
    {
      var newItem = DMXDraws.NonVisualGroupDrawingShapePropsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.NonVisualGroupDrawingShapePropsExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
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
  
  public static DMDraws.NonVisualGroupDrawingShapePropsExtensionList? CreateModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualGroupDrawingShapePropsExtensionList();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value)
    where OpenXmlElementType: DXDraw.NonVisualGroupDrawingShapePropsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensions);
      return openXmlElement;
    }
    return default;
  }
}
