namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Doughnut Charts.
/// </summary>
public static class DoughnutChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.DoughnutChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.DoughnutChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.DoughnutChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.PieChartSeries>? GetPieChartSeries(DXDC.DoughnutChart openXmlElement)
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
  
  private static bool CmpPieChartSeries(DXDC.DoughnutChart openXmlElement, Collection<DMDC.PieChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetPieChartSeries(DXDC.DoughnutChart openXmlElement, Collection<DMDC.PieChartSeries>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.DoughnutChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.DoughnutChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.DoughnutChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static UInt16? GetFirstSliceAngle(DXDC.DoughnutChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.FirstSliceAngle>()?.Val);
  }
  
  private static bool CmpFirstSliceAngle(DXDC.DoughnutChart openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.FirstSliceAngle>()?.Val, value, diffs, objName, "FirstSliceAngle");
  }
  
  private static void SetFirstSliceAngle(DXDC.DoughnutChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.FirstSliceAngle,System.UInt16>(openXmlElement, value);
  }
  
  private static Byte? GetHoleSize(DXDC.DoughnutChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.HoleSize>()?.Val);
  }
  
  private static bool CmpHoleSize(DXDC.DoughnutChart openXmlElement, Byte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.HoleSize>()?.Val, value, diffs, objName, "HoleSize");
  }
  
  private static void SetHoleSize(DXDC.DoughnutChart openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDC.HoleSize,System.Byte>(openXmlElement, value);
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.DoughnutChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.DoughnutChart openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.DoughnutChart openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.DoughnutChart? CreateModelElement(DXDC.DoughnutChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.DoughnutChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.FirstSliceAngle = GetFirstSliceAngle(openXmlElement);
      value.HoleSize = GetHoleSize(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DoughnutChart? openXmlElement, DMDC.DoughnutChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!CmpFirstSliceAngle(openXmlElement, value.FirstSliceAngle, diffs, objName, propName))
        ok = false;
      if (!CmpHoleSize(openXmlElement, value.HoleSize, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DoughnutChart value)
    where OpenXmlElementType: DXDC.DoughnutChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DoughnutChart openXmlElement, DMDC.DoughnutChart value)
  {
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetPieChartSeries(openXmlElement, value?.PieChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetFirstSliceAngle(openXmlElement, value?.FirstSliceAngle);
    SetHoleSize(openXmlElement, value?.HoleSize);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
