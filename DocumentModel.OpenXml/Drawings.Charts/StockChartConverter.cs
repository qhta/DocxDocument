namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Stock Charts.
/// </summary>
public static class StockChartConverter
{
  private static Collection<DMDC.LineChartSeries>? GetLineChartSeries(DXDC.StockChart openXmlElement)
  {
    var collection = new Collection<DMDC.LineChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.LineChartSeries>())
    {
      var newItem = DMXDC.LineChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLineChartSeries(DXDC.StockChart openXmlElement, Collection<DMDC.LineChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.LineChartSeries>();
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
        if (!DMXDC.LineChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineChartSeries(DXDC.StockChart openXmlElement, Collection<DMDC.LineChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.LineChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.LineChartSeriesConverter.CreateOpenXmlElement<DXDC.LineChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.StockChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.StockChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.StockChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static DMDC.DropLines? GetDropLines(DXDC.StockChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DropLines>();
    if (element != null)
      return DMXDC.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDC.StockChart openXmlElement, DMDC.DropLines? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DropLines>(), value, diffs, objName);
  }
  
  private static void SetDropLines(DXDC.StockChart openXmlElement, DMDC.DropLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DropLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DropLinesConverter.CreateOpenXmlElement<DXDC.DropLines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.HighLowLines? GetHighLowLines(DXDC.StockChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.HighLowLines>();
    if (element != null)
      return DMXDC.HighLowLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHighLowLines(DXDC.StockChart openXmlElement, DMDC.HighLowLines? value, DiffList? diffs, string? objName)
  {
    return DMXDC.HighLowLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.HighLowLines>(), value, diffs, objName);
  }
  
  private static void SetHighLowLines(DXDC.StockChart openXmlElement, DMDC.HighLowLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.HighLowLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.HighLowLinesConverter.CreateOpenXmlElement<DXDC.HighLowLines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.UpDownBars? GetUpDownBars(DXDC.StockChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.UpDownBars>();
    if (element != null)
      return DMXDC.UpDownBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpDownBars(DXDC.StockChart openXmlElement, DMDC.UpDownBars? value, DiffList? diffs, string? objName)
  {
    return DMXDC.UpDownBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.UpDownBars>(), value, diffs, objName);
  }
  
  private static void SetUpDownBars(DXDC.StockChart openXmlElement, DMDC.UpDownBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.UpDownBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.UpDownBarsConverter.CreateOpenXmlElement<DXDC.UpDownBars>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.StockChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDC.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXDC.StockChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.AxisId>();
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
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAxisIds(DXDC.StockChart openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDC.AxisId>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.StockChartExtensionList? GetStockChartExtensionList(DXDC.StockChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StockChartExtensionList>();
    if (element != null)
      return DMXDC.StockChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStockChartExtensionList(DXDC.StockChart openXmlElement, DMDC.StockChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.StockChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StockChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetStockChartExtensionList(DXDC.StockChart openXmlElement, DMDC.StockChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StockChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StockChartExtensionListConverter.CreateOpenXmlElement<DXDC.StockChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.StockChart? CreateModelElement(DXDC.StockChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChart();
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.HighLowLines = GetHighLowLines(openXmlElement);
      value.UpDownBars = GetUpDownBars(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.StockChartExtensionList = GetStockChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StockChart? openXmlElement, DMDC.StockChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineChartSeries(openXmlElement, value.LineChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpDropLines(openXmlElement, value.DropLines, diffs, objName))
        ok = false;
      if (!CmpHighLowLines(openXmlElement, value.HighLowLines, diffs, objName))
        ok = false;
      if (!CmpUpDownBars(openXmlElement, value.UpDownBars, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpStockChartExtensionList(openXmlElement, value.StockChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StockChart value)
    where OpenXmlElementType: DXDC.StockChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StockChart openXmlElement, DMDC.StockChart value)
  {
    SetLineChartSeries(openXmlElement, value?.LineChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetDropLines(openXmlElement, value?.DropLines);
    SetHighLowLines(openXmlElement, value?.HighLowLines);
    SetUpDownBars(openXmlElement, value?.UpDownBars);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetStockChartExtensionList(openXmlElement, value?.StockChartExtensionList);
  }
}
