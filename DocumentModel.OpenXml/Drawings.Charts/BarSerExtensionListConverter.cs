namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public static class BarSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.BarSerExtension>? GetBarSerExtensions(DXDrawCharts.BarSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BarSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BarSerExtension>())
    {
      var newItem = DMXDrawsCharts.BarSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBarSerExtensions(DXDrawCharts.BarSerExtensionList openXmlElement, Collection<DMDrawsCharts.BarSerExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.BarSerExtension>();
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
        if (!DMXDrawsCharts.BarSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarSerExtensions(DXDrawCharts.BarSerExtensionList openXmlElement, Collection<DMDrawsCharts.BarSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BarSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BarSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BarSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarSerExtensionList? CreateModelElement(DXDrawCharts.BarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarSerExtensionList();
      value.BarSerExtensions = GetBarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BarSerExtensionList? openXmlElement, DMDrawsCharts.BarSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarSerExtensions(openXmlElement, value.BarSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.BarSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarSerExtensions(openXmlElement, value?.BarSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
