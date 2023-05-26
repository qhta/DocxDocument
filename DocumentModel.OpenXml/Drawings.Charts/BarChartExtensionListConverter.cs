namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public static class BarChartExtensionListConverter
{
  private static Collection<DMDC.BarChartExtension>? GetBarChartExtensions(DXDC.BarChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.BarChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.BarChartExtension>())
    {
      var newItem = DMXDC.BarChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBarChartExtensions(DXDC.BarChartExtensionList openXmlElement, Collection<DMDC.BarChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.BarChartExtension>();
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
        if (!DMXDC.BarChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarChartExtensions(DXDC.BarChartExtensionList openXmlElement, Collection<DMDC.BarChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.BarChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.BarChartExtensionConverter.CreateOpenXmlElement<DXDC.BarChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtensionList? CreateModelElement(DXDC.BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtensionList();
      value.BarChartExtensions = GetBarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BarChartExtensionList? openXmlElement, DMDC.BarChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarChartExtensions(openXmlElement, value.BarChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BarChartExtensionList value)
    where OpenXmlElementType: DXDC.BarChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BarChartExtensionList openXmlElement, DMDC.BarChartExtensionList value)
  {
    SetBarChartExtensions(openXmlElement, value?.BarChartExtensions);
  }
}
