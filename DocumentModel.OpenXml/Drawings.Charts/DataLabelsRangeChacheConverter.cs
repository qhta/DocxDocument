namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public static class DataLabelsRangeChacheConverter
{
  private static UInt32? GetPointCount(DXO2013DrawChart.DataLabelsRangeChache openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDrawsCharts.StringPoint>? GetStringPoints(DXO2013DrawChart.DataLabelsRangeChache openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StringPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StringPoint>())
    {
      var newItem = DMXDrawsCharts.StringPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStringPoints(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, Collection<DMDrawsCharts.StringPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.StringPoint>();
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
        if (!DMXDrawsCharts.StringPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStringPoints(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, Collection<DMDrawsCharts.StringPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StringPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StringPointConverter.CreateOpenXmlElement<DXDrawCharts.StringPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.StrDataExtensionList? GetStrDataExtensionList(DXO2013DrawChart.DataLabelsRangeChache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StrDataExtensionList>();
    if (element != null)
      return DMXDrawsCharts.StrDataExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStrDataExtensionList(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, DMDrawsCharts.StrDataExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StrDataExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StrDataExtensionList>(), value, diffs, objName);
  }
  
  private static void SetStrDataExtensionList(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, DMDrawsCharts.StrDataExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StrDataExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StrDataExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.StrDataExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelsRangeChache? CreateModelElement(DXO2013DrawChart.DataLabelsRangeChache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelsRangeChache();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.DataLabelsRangeChache? openXmlElement, DMDrawsCharts.DataLabelsRangeChache? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      if (!CmpStringPoints(openXmlElement, value.StringPoints, diffs, objName))
        ok = false;
      if (!CmpStrDataExtensionList(openXmlElement, value.StrDataExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabelsRangeChache value)
    where OpenXmlElementType: DXO2013DrawChart.DataLabelsRangeChache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.DataLabelsRangeChache openXmlElement, DMDrawsCharts.DataLabelsRangeChache value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
    SetStringPoints(openXmlElement, value?.StringPoints);
    SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
  }
}
