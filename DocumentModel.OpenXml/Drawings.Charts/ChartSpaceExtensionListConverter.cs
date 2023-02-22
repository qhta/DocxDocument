namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public static class ChartSpaceExtensionListConverter
{
  private static Collection<DMDrawsCharts.ChartSpaceExtension>? GetChartSpaceExtensions(DXDrawCharts.ChartSpaceExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ChartSpaceExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ChartSpaceExtension>())
    {
      var newItem = DMXDrawsCharts.ChartSpaceExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpChartSpaceExtensions(DXDrawCharts.ChartSpaceExtensionList openXmlElement, Collection<DMDrawsCharts.ChartSpaceExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.ChartSpaceExtension>();
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
        if (!DMXDrawsCharts.ChartSpaceExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetChartSpaceExtensions(DXDrawCharts.ChartSpaceExtensionList openXmlElement, Collection<DMDrawsCharts.ChartSpaceExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ChartSpaceExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ChartSpaceExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ChartSpaceExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpaceExtensionList? CreateModelElement(DXDrawCharts.ChartSpaceExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtensionList();
      value.ChartSpaceExtensions = GetChartSpaceExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ChartSpaceExtensionList? openXmlElement, DMDrawsCharts.ChartSpaceExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartSpaceExtensions(openXmlElement, value.ChartSpaceExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartSpaceExtensionList value)
    where OpenXmlElementType: DXDrawCharts.ChartSpaceExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ChartSpaceExtensionList openXmlElement, DMDrawsCharts.ChartSpaceExtensionList value)
  {
    SetChartSpaceExtensions(openXmlElement, value?.ChartSpaceExtensions);
    }
  }
