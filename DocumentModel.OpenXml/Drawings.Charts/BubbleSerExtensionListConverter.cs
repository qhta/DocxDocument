namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public static class BubbleSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.BubbleSerExtension> GetBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleSerExtension>())
    {
      var newItem = DMXDrawsCharts.BubbleSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleSerExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.BubbleSerExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMDrawsCharts.BubbleSerExtensionList? CreateModelElement(DXDrawCharts.BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BubbleSerExtensionList();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.BubbleSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleSerExtensions(openXmlElement, value?.BubbleSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
