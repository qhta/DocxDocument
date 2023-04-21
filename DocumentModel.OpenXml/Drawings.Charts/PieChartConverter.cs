namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
public static class PieChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.PieChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.PieChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.PieChart openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDC.PieChartSeries>? GetPieChartSeries(DXDC.PieChart openXmlElement)
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
  
  private static bool CmpPieChartSeries(DXDC.PieChart openXmlElement, Collection<DMDC.PieChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.PieChartSeries>();
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
        if (!DMXDC.PieChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPieChartSeries(DXDC.PieChart openXmlElement, Collection<DMDC.PieChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.PieChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.PieChartSeriesConverter.CreateOpenXmlElement<DXDC.PieChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.PieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.PieChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.PieChart openXmlElement, DMDC.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetFirstSliceAngle(DXDC.PieChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.FirstSliceAngle>()?.Val);
  }
  
  private static bool CmpFirstSliceAngle(DXDC.PieChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.FirstSliceAngle>()?.Val, value, diffs, objName, "FirstSliceAngle");
  }
  
  private static void SetFirstSliceAngle(DXDC.PieChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.FirstSliceAngle,System.UInt16>(openXmlElement, value);
  }
  
  private static DMDC.PieChartExtensionList? GetPieChartExtensionList(DXDC.PieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PieChartExtensionList>();
    if (element != null)
      return DMXDC.PieChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPieChartExtensionList(DXDC.PieChart openXmlElement, DMDC.PieChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PieChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PieChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetPieChartExtensionList(DXDC.PieChart openXmlElement, DMDC.PieChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PieChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PieChartExtensionListConverter.CreateOpenXmlElement<DXDC.PieChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChart? CreateModelElement(DXDC.PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.FirstSliceAngle = GetFirstSliceAngle(openXmlElement);
      value.PieChartExtensionList = GetPieChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PieChart? openXmlElement, DMDC.PieChart? value, DiffList? diffs, string? objName)
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
      if (!CmpFirstSliceAngle(openXmlElement, value.FirstSliceAngle, diffs, objName))
        ok = false;
      if (!CmpPieChartExtensionList(openXmlElement, value.PieChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PieChart value)
    where OpenXmlElementType: DXDC.PieChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PieChart openXmlElement, DMDC.PieChart value)
  {
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetPieChartSeries(openXmlElement, value?.PieChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetFirstSliceAngle(openXmlElement, value?.FirstSliceAngle);
    SetPieChartExtensionList(openXmlElement, value?.PieChartExtensionList);
  }
}
