namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public static class Area3DChartExtensionListConverter
{
  private static Collection<DMDC.Area3DChartExtension>? GetArea3DChartExtensions(DXDC.Area3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.Area3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.Area3DChartExtension>())
    {
      var newItem = DMXDC.Area3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpArea3DChartExtensions(DXDC.Area3DChartExtensionList openXmlElement, Collection<DMDC.Area3DChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.Area3DChartExtension>();
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
        if (!DMXDC.Area3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetArea3DChartExtensions(DXDC.Area3DChartExtensionList openXmlElement, Collection<DMDC.Area3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Area3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.Area3DChartExtensionConverter.CreateOpenXmlElement<DXDC.Area3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChartExtensionList? CreateModelElement(DXDC.Area3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Area3DChartExtensionList();
      value.Area3DChartExtensions = GetArea3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Area3DChartExtensionList? openXmlElement, DMDC.Area3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpArea3DChartExtensions(openXmlElement, value.Area3DChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Area3DChartExtensionList value)
    where OpenXmlElementType: DXDC.Area3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Area3DChartExtensionList openXmlElement, DMDC.Area3DChartExtensionList value)
  {
    SetArea3DChartExtensions(openXmlElement, value?.Area3DChartExtensions);
  }
}
