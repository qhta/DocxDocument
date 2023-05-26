namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public static class BubbleChartExtensionListConverter
{
  private static Collection<DMDC.BubbleChartExtension>? GetBubbleChartExtensions(DXDC.BubbleChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.BubbleChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.BubbleChartExtension>())
    {
      var newItem = DMXDC.BubbleChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBubbleChartExtensions(DXDC.BubbleChartExtensionList openXmlElement, Collection<DMDC.BubbleChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.BubbleChartExtension>();
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
        if (!DMXDC.BubbleChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBubbleChartExtensions(DXDC.BubbleChartExtensionList openXmlElement, Collection<DMDC.BubbleChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.BubbleChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.BubbleChartExtensionConverter.CreateOpenXmlElement<DXDC.BubbleChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtensionList? CreateModelElement(DXDC.BubbleChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtensionList();
      value.BubbleChartExtensions = GetBubbleChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BubbleChartExtensionList? openXmlElement, DMDC.BubbleChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBubbleChartExtensions(openXmlElement, value.BubbleChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BubbleChartExtensionList value)
    where OpenXmlElementType: DXDC.BubbleChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BubbleChartExtensionList openXmlElement, DMDC.BubbleChartExtensionList value)
  {
    SetBubbleChartExtensions(openXmlElement, value?.BubbleChartExtensions);
  }
}
