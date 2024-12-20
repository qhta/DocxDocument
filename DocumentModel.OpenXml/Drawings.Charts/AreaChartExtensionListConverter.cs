namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public static class AreaChartExtensionListConverter
{
  private static Collection<DMDC.AreaChartExtension>? GetAreaChartExtensions(DXDC.AreaChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.AreaChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.AreaChartExtension>())
    {
      var newItem = DMXDC.AreaChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAreaChartExtensions(DXDC.AreaChartExtensionList openXmlElement, Collection<DMDC.AreaChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.AreaChartExtension>();
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
        if (!DMXDC.AreaChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAreaChartExtensions(DXDC.AreaChartExtensionList openXmlElement, Collection<DMDC.AreaChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.AreaChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.AreaChartExtensionConverter.CreateOpenXmlElement<DXDC.AreaChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.AreaChartExtensionList? CreateModelElement(DXDC.AreaChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.AreaChartExtensionList();
      value.AreaChartExtensions = GetAreaChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.AreaChartExtensionList? openXmlElement, DMDC.AreaChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaChartExtensions(openXmlElement, value.AreaChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.AreaChartExtensionList value)
    where OpenXmlElementType: DXDC.AreaChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.AreaChartExtensionList openXmlElement, DMDC.AreaChartExtensionList value)
  {
    SetAreaChartExtensions(openXmlElement, value?.AreaChartExtensions);
  }
}
