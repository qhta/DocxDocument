namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public static class BubbleSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.BubbleSerExtension>? GetBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleSerExtension>())
    {
      var newItem = DMXDrawsCharts.BubbleSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleSerExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.BubbleSerExtension>();
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
        if (!DMXDrawsCharts.BubbleSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BubbleSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BubbleSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BubbleSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleSerExtensionList? CreateModelElement(DXDrawCharts.BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleSerExtensionList();
      value.BubbleSerExtensions = GetBubbleSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BubbleSerExtensionList? openXmlElement, DMDrawsCharts.BubbleSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBubbleSerExtensions(openXmlElement, value.BubbleSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleSerExtensionList value)
    where OpenXmlElementType: DXDrawCharts.BubbleSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BubbleSerExtensionList openXmlElement, DMDrawsCharts.BubbleSerExtensionList value)
  {
    SetBubbleSerExtensions(openXmlElement, value?.BubbleSerExtensions);
  }
}
