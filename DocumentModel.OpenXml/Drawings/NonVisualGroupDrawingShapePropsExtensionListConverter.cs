namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionListConverter
{
  private static Collection<DMD.NonVisualGroupDrawingShapePropsExtension>? GetNonVisualGroupDrawingShapePropsExtensions(DXD.NonVisualGroupDrawingShapePropsExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.NonVisualGroupDrawingShapePropsExtension>();
    foreach (var item in openXmlElement.Elements<DXD.NonVisualGroupDrawingShapePropsExtension>())
    {
      var newItem = DMXD.NonVisualGroupDrawingShapePropsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensions(DXD.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, Collection<DMD.NonVisualGroupDrawingShapePropsExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.NonVisualGroupDrawingShapePropsExtension>();
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
        if (!DMXD.NonVisualGroupDrawingShapePropsExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensions(DXD.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, Collection<DMD.NonVisualGroupDrawingShapePropsExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.NonVisualGroupDrawingShapePropsExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.NonVisualGroupDrawingShapePropsExtensionConverter.CreateOpenXmlElement<DXD.NonVisualGroupDrawingShapePropsExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.NonVisualGroupDrawingShapePropsExtensionList? CreateModelElement(DXD.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.NonVisualGroupDrawingShapePropsExtensionList();
      value.NonVisualGroupDrawingShapePropsExtensions = GetNonVisualGroupDrawingShapePropsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value.NonVisualGroupDrawingShapePropsExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualGroupDrawingShapePropsExtensionList value)
    where OpenXmlElementType: DXD.NonVisualGroupDrawingShapePropsExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtensionList value)
  {
    SetNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensions);
  }
}
