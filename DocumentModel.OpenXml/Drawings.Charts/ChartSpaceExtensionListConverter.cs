namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public static class ChartSpaceExtensionListConverter
{
  private static Collection<DMDC.ChartSpaceExtension>? GetChartSpaceExtensions(DXDC.ChartSpaceExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.ChartSpaceExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.ChartSpaceExtension>())
    {
      var newItem = DMXDC.ChartSpaceExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpChartSpaceExtensions(DXDC.ChartSpaceExtensionList openXmlElement, Collection<DMDC.ChartSpaceExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.ChartSpaceExtension>();
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
        if (!DMXDC.ChartSpaceExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetChartSpaceExtensions(DXDC.ChartSpaceExtensionList openXmlElement, Collection<DMDC.ChartSpaceExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.ChartSpaceExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.ChartSpaceExtensionConverter.CreateOpenXmlElement<DXDC.ChartSpaceExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpaceExtensionList? CreateModelElement(DXDC.ChartSpaceExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtensionList();
      value.ChartSpaceExtensions = GetChartSpaceExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ChartSpaceExtensionList? openXmlElement, DMDC.ChartSpaceExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartSpaceExtensions(openXmlElement, value.ChartSpaceExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartSpaceExtensionList value)
    where OpenXmlElementType: DXDC.ChartSpaceExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartSpaceExtensionList openXmlElement, DMDC.ChartSpaceExtensionList value)
  {
    SetChartSpaceExtensions(openXmlElement, value?.ChartSpaceExtensions);
  }
}
