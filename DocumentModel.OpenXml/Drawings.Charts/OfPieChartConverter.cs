namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public static class OfPieChartConverter
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  private static DMDrawsCharts.OfPieKind? GetOfPieType(DXDrawCharts.OfPieChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDrawsCharts.OfPieKind>(openXmlElement.GetFirstChild<DXDrawCharts.OfPieType>()?.Val?.Value);
  }
  
  private static bool CmpOfPieType(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.OfPieKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDrawsCharts.OfPieKind>(openXmlElement.GetFirstChild<DXDrawCharts.OfPieType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfPieType(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.OfPieKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.OfPieType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.OfPieType, DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDrawsCharts.OfPieKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.OfPieChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.OfPieChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDrawCharts.OfPieChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.PieChartSeries>? GetPieChartSeries(DXDrawCharts.OfPieChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieChartSeries>())
    {
      var newItem = DMXDrawsCharts.PieChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPieChartSeries(DXDrawCharts.OfPieChart openXmlElement, Collection<DMDrawsCharts.PieChartSeries>? value, DiffList? diffs, string? objName)
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
  
  private static void SetPieChartSeries(DXDrawCharts.OfPieChart openXmlElement, Collection<DMDrawsCharts.PieChartSeries>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.OfPieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabels(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static UInt16? GetGapWidth(DXDrawCharts.OfPieChart openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>()?.Val?.Value;
  }
  
  private static bool CmpGapWidth(DXDrawCharts.OfPieChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.GapWidth", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGapWidth(DXDrawCharts.OfPieChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.GapWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.SplitKind? GetSplitType(DXDrawCharts.OfPieChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDrawsCharts.SplitKind>(openXmlElement.GetFirstChild<DXDrawCharts.SplitType>()?.Val?.Value);
  }
  
  private static bool CmpSplitType(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.SplitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDrawsCharts.SplitKind>(openXmlElement.GetFirstChild<DXDrawCharts.SplitType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSplitType(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.SplitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SplitType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.SplitType, DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDrawsCharts.SplitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetSplitPosition(DXDrawCharts.OfPieChart openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.SplitPosition>()?.Val?.Value;
  }
  
  private static bool CmpSplitPosition(DXDrawCharts.OfPieChart openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SplitPosition>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.SplitPosition", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSplitPosition(DXDrawCharts.OfPieChart openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SplitPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.SplitPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.CustomSplit? GetCustomSplit(DXDrawCharts.OfPieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.CustomSplit>();
    if (element != null)
      return DMXDrawsCharts.CustomSplitConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomSplit(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.CustomSplit? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CustomSplitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.CustomSplit>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomSplit(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.CustomSplit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CustomSplit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.CustomSplitConverter.CreateOpenXmlElement<DXDrawCharts.CustomSplit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetSecondPieSize(DXDrawCharts.OfPieChart openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.SecondPieSize>()?.Val?.Value;
  }
  
  private static bool CmpSecondPieSize(DXDrawCharts.OfPieChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SecondPieSize>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.SecondPieSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSecondPieSize(DXDrawCharts.OfPieChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SecondPieSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.SecondPieSize{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.SeriesLines>? GetSeriesLines(DXDrawCharts.OfPieChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SeriesLines>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SeriesLines>())
    {
      var newItem = DMXDrawsCharts.SeriesLinesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSeriesLines(DXDrawCharts.OfPieChart openXmlElement, Collection<DMDrawsCharts.SeriesLines>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.SeriesLines>();
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
        if (!DMXDrawsCharts.SeriesLinesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSeriesLines(DXDrawCharts.OfPieChart openXmlElement, Collection<DMDrawsCharts.SeriesLines>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SeriesLines>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SeriesLinesConverter.CreateOpenXmlElement<DXDrawCharts.SeriesLines>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.OfPieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.OfPieChart openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.OfPieChart? CreateModelElement(DXDrawCharts.OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.OfPieChart();
      value.OfPieType = GetOfPieType(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.SplitType = GetSplitType(openXmlElement);
      value.SplitPosition = GetSplitPosition(openXmlElement);
      value.CustomSplit = GetCustomSplit(openXmlElement);
      value.SecondPieSize = GetSecondPieSize(openXmlElement);
      value.SeriesLines = GetSeriesLines(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.OfPieChart? openXmlElement, DMDrawsCharts.OfPieChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOfPieType(openXmlElement, value.OfPieType, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpPieChartSeries(openXmlElement, value.PieChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpGapWidth(openXmlElement, value.GapWidth, diffs, objName))
        ok = false;
      if (!CmpSplitType(openXmlElement, value.SplitType, diffs, objName))
        ok = false;
      if (!CmpSplitPosition(openXmlElement, value.SplitPosition, diffs, objName))
        ok = false;
      if (!CmpCustomSplit(openXmlElement, value.CustomSplit, diffs, objName))
        ok = false;
      if (!CmpSecondPieSize(openXmlElement, value.SecondPieSize, diffs, objName))
        ok = false;
      if (!CmpSeriesLines(openXmlElement, value.SeriesLines, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.OfPieChart? value)
    where OpenXmlElementType: DXDrawCharts.OfPieChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfPieType(openXmlElement, value?.OfPieType);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSeries(openXmlElement, value?.PieChartSeries);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetSplitType(openXmlElement, value?.SplitType);
      SetSplitPosition(openXmlElement, value?.SplitPosition);
      SetCustomSplit(openXmlElement, value?.CustomSplit);
      SetSecondPieSize(openXmlElement, value?.SecondPieSize);
      SetSeriesLines(openXmlElement, value?.SeriesLines);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
