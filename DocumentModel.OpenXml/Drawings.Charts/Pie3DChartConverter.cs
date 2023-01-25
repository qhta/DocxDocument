namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public static class Pie3DChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.Pie3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.Pie3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null == value;
  }
  
  private static void SetVaryColors(DXDrawCharts.Pie3DChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.PieChartSeries> GetPieChartSeries(DXDrawCharts.Pie3DChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieChartSeries>())
    {
      var newItem = DMXDrawsCharts.PieChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPieChartSeries(DXDrawCharts.Pie3DChart openXmlElement, Collection<DMDrawsCharts.PieChartSeries>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.PieChartSeries>();
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
        if (!DMXDrawsCharts.PieChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPieChartSeries(DXDrawCharts.Pie3DChart openXmlElement, Collection<DMDrawsCharts.PieChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.PieChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.PieChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.PieChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.Pie3DChart openXmlElement)
  {
    return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>());
  }
  
  private static bool CmpDataLabels(DXDrawCharts.Pie3DChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabels(DXDrawCharts.Pie3DChart openXmlElement, DMDrawsCharts.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelsConverter.CreateOpenXmlElement<DXDrawCharts.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Pie3DChartExtensionList? GetPie3DChartExtensionList(DXDrawCharts.Pie3DChart openXmlElement)
  {
    return DMXDrawsCharts.Pie3DChartExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Pie3DChartExtensionList>());
  }
  
  private static bool CmpPie3DChartExtensionList(DXDrawCharts.Pie3DChart openXmlElement, DMDrawsCharts.Pie3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Pie3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Pie3DChartExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPie3DChartExtensionList(DXDrawCharts.Pie3DChart openXmlElement, DMDrawsCharts.Pie3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Pie3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Pie3DChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.Pie3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Pie3DChart? CreateModelElement(DXDrawCharts.Pie3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Pie3DChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Pie3DChartExtensionList = GetPie3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Pie3DChart? openXmlElement, DMDrawsCharts.Pie3DChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpPieChartSeries(openXmlElement, value.PieChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpPie3DChartExtensionList(openXmlElement, value.Pie3DChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Pie3DChart? value)
    where OpenXmlElementType: DXDrawCharts.Pie3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSeries(openXmlElement, value?.PieChartSeries);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetPie3DChartExtensionList(openXmlElement, value?.Pie3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
