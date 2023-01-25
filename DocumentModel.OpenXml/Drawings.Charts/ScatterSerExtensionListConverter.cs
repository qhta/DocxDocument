namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public static class ScatterSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.ScatterSerExtension> GetScatterSerExtensions(DXDrawCharts.ScatterSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ScatterSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ScatterSerExtension>())
    {
      var newItem = DMXDrawsCharts.ScatterSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpScatterSerExtensions(DXDrawCharts.ScatterSerExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterSerExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.ScatterSerExtension>();
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
        if (!DMXDrawsCharts.ScatterSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetScatterSerExtensions(DXDrawCharts.ScatterSerExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ScatterSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ScatterSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ScatterSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.ScatterSerExtensionList? CreateModelElement(DXDrawCharts.ScatterSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterSerExtensionList();
      value.ScatterSerExtensions = GetScatterSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ScatterSerExtensionList? openXmlElement, DMDrawsCharts.ScatterSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterSerExtensions(openXmlElement, value.ScatterSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ScatterSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterSerExtensions(openXmlElement, value?.ScatterSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
