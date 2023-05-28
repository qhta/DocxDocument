namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public static class Pie3DChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.Pie3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.Pie3DChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.Pie3DChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.VaryColors();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDC.PieChartSeries>? GetPieChartSeries(DXDC.Pie3DChart openXmlElement)
  {
    var collection = new Collection<DMDC.PieChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.PieChartSeries>())
    {
      var newItem = DMXDC.PieChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPieChartSeries(DXDC.Pie3DChart openXmlElement, Collection<DMDC.PieChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.PieChartSeries>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.PieChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPieChartSeries(DXDC.Pie3DChart openXmlElement, Collection<DMDC.PieChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.PieChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.PieChartSeriesConverter.CreateOpenXmlElement<DXDC.PieChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.Pie3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.Pie3DChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.Pie3DChart openXmlElement, DMDC.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Pie3DChartExtensionList? GetPie3DChartExtensionList(DXDC.Pie3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Pie3DChartExtensionList>();
    if (element != null)
      return DMXDC.Pie3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPie3DChartExtensionList(DXDC.Pie3DChart openXmlElement, DMDC.Pie3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.Pie3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Pie3DChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetPie3DChartExtensionList(DXDC.Pie3DChart openXmlElement, DMDC.Pie3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Pie3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Pie3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Pie3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.Pie3DChart? CreateModelElement(DXDC.Pie3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Pie3DChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Pie3DChartExtensionList = GetPie3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Pie3DChart? openXmlElement, DMDC.Pie3DChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName, propName))
        ok = false;
      if (!CmpPieChartSeries(openXmlElement, value.PieChartSeries, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName, propName))
        ok = false;
      if (!CmpPie3DChartExtensionList(openXmlElement, value.Pie3DChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Pie3DChart value)
    where OpenXmlElementType: DXDC.Pie3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Pie3DChart openXmlElement, DMDC.Pie3DChart value)
  {
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetPieChartSeries(openXmlElement, value?.PieChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetPie3DChartExtensionList(openXmlElement, value?.Pie3DChartExtensionList);
  }
}
