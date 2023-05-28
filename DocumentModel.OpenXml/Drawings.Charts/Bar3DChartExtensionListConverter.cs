namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public static class Bar3DChartExtensionListConverter
{
  private static Collection<DMDC.Bar3DChartExtension>? GetBar3DChartExtensions(DXDC.Bar3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.Bar3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.Bar3DChartExtension>())
    {
      var newItem = DMXDC.Bar3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBar3DChartExtensions(DXDC.Bar3DChartExtensionList openXmlElement, Collection<DMDC.Bar3DChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.Bar3DChartExtension>();
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
        if (!DMXDC.Bar3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBar3DChartExtensions(DXDC.Bar3DChartExtensionList openXmlElement, Collection<DMDC.Bar3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Bar3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.Bar3DChartExtensionConverter.CreateOpenXmlElement<DXDC.Bar3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.Bar3DChartExtensionList? CreateModelElement(DXDC.Bar3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Bar3DChartExtensionList();
      value.Bar3DChartExtensions = GetBar3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Bar3DChartExtensionList? openXmlElement, DMDC.Bar3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBar3DChartExtensions(openXmlElement, value.Bar3DChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Bar3DChartExtensionList value)
    where OpenXmlElementType: DXDC.Bar3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Bar3DChartExtensionList openXmlElement, DMDC.Bar3DChartExtensionList value)
  {
    SetBar3DChartExtensions(openXmlElement, value?.Bar3DChartExtensions);
  }
}
