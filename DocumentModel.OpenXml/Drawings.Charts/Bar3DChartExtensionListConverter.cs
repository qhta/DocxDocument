namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public static class Bar3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Bar3DChartExtension>? GetBar3DChartExtensions(DXDrawCharts.Bar3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Bar3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Bar3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Bar3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBar3DChartExtensions(DXDrawCharts.Bar3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Bar3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.Bar3DChartExtension>();
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
        if (!DMXDrawsCharts.Bar3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBar3DChartExtensions(DXDrawCharts.Bar3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Bar3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Bar3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Bar3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Bar3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Bar3DChartExtensionList? CreateModelElement(DXDrawCharts.Bar3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Bar3DChartExtensionList();
      value.Bar3DChartExtensions = GetBar3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Bar3DChartExtensionList? openXmlElement, DMDrawsCharts.Bar3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBar3DChartExtensions(openXmlElement, value.Bar3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Bar3DChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.Bar3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Bar3DChartExtensionList openXmlElement, DMDrawsCharts.Bar3DChartExtensionList value)
  {
    SetBar3DChartExtensions(openXmlElement, value?.Bar3DChartExtensions);
    }
  }
