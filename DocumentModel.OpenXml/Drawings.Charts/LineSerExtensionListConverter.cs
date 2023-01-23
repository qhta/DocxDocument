namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public static class LineSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.LineSerExtension> GetLineSerExtensions(DXDrawCharts.LineSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.LineSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.LineSerExtension>())
    {
      var newItem = DMXDrawsCharts.LineSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLineSerExtensions(DXDrawCharts.LineSerExtensionList openXmlElement, Collection<DMDrawsCharts.LineSerExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.LineSerExtension>();
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
        if (!DMXDrawsCharts.LineSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetLineSerExtensions(DXDrawCharts.LineSerExtensionList openXmlElement, Collection<DMDrawsCharts.LineSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.LineSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.LineSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.LineSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.LineSerExtensionList? CreateModelElement(DXDrawCharts.LineSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.LineSerExtensionList();
      value.LineSerExtensions = GetLineSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.LineSerExtensionList? openXmlElement, DMDrawsCharts.LineSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineSerExtensions(openXmlElement, value.LineSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.LineSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineSerExtensions(openXmlElement, value?.LineSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
