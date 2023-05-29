namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public static class Line3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Line3DChartExtension>? GetLine3DChartExtensions(DXDrawCharts.Line3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Line3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Line3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Line3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLine3DChartExtensions(DXDrawCharts.Line3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Line3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.Line3DChartExtension>();
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
        if (!DMXDrawsCharts.Line3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLine3DChartExtensions(DXDrawCharts.Line3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Line3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Line3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Line3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Line3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChartExtensionList? CreateModelElement(DXDrawCharts.Line3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChartExtensionList();
      value.Line3DChartExtensions = GetLine3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Line3DChartExtensionList? openXmlElement, DMDrawsCharts.Line3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLine3DChartExtensions(openXmlElement, value.Line3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Line3DChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.Line3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Line3DChartExtensionList openXmlElement, DMDrawsCharts.Line3DChartExtensionList value)
  {
    SetLine3DChartExtensions(openXmlElement, value?.Line3DChartExtensions);
  }
}
