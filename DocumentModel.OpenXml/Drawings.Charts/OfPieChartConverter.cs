namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public static class OfPieChartConverter
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  private static DMDC.OfPieKind? GetOfPieType(DXDC.OfPieChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>(openXmlElement.GetFirstChild<DXDC.OfPieType>()?.Val?.Value);
  }
  
  private static bool CmpOfPieType(DXDC.OfPieChart openXmlElement, DMDC.OfPieKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>(openXmlElement.GetFirstChild<DXDC.OfPieType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetOfPieType(DXDC.OfPieChart openXmlElement, DMDC.OfPieKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.OfPieType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>(itemElement, (DMDC.OfPieKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.OfPieType, DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>((DMDC.OfPieKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.OfPieChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.OfPieChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.OfPieChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.PieChartSeries>? GetPieChartSeries(DXDC.OfPieChart openXmlElement)
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
  
  private static bool CmpPieChartSeries(DXDC.OfPieChart openXmlElement, Collection<DMDC.PieChartSeries>? value, DiffList? diffs, string? objName)
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
  
  private static void SetPieChartSeries(DXDC.OfPieChart openXmlElement, Collection<DMDC.PieChartSeries>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.OfPieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.OfPieChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.OfPieChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static UInt16? GetGapWidth(DXDC.OfPieChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val);
  }
  
  private static bool CmpGapWidth(DXDC.OfPieChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val, value, diffs, objName, "GapWidth");
  }
  
  private static void SetGapWidth(DXDC.OfPieChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapWidth,System.UInt16>(openXmlElement, value);
  }
  
  private static DMDC.SplitKind? GetSplitType(DXDC.OfPieChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>(openXmlElement.GetFirstChild<DXDC.SplitType>()?.Val?.Value);
  }
  
  private static bool CmpSplitType(DXDC.OfPieChart openXmlElement, DMDC.SplitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>(openXmlElement.GetFirstChild<DXDC.SplitType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSplitType(DXDC.OfPieChart openXmlElement, DMDC.SplitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SplitType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>(itemElement, (DMDC.SplitKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.SplitType, DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>((DMDC.SplitKind)value));
  }
  
  private static Double? GetSplitPosition(DXDC.OfPieChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.SplitPosition>()?.Val);
  }
  
  private static bool CmpSplitPosition(DXDC.OfPieChart openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.SplitPosition>()?.Val, value, diffs, objName, "SplitPosition");
  }
  
  private static void SetSplitPosition(DXDC.OfPieChart openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.SplitPosition,System.Double>(openXmlElement, value);
  }
  
  private static DMDC.CustomSplit? GetCustomSplit(DXDC.OfPieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.CustomSplit>();
    if (element != null)
      return DMXDC.CustomSplitConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomSplit(DXDC.OfPieChart openXmlElement, DMDC.CustomSplit? value, DiffList? diffs, string? objName)
  {
    return DMXDC.CustomSplitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.CustomSplit>(), value, diffs, objName);
  }
  
  private static void SetCustomSplit(DXDC.OfPieChart openXmlElement, DMDC.CustomSplit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.CustomSplit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CustomSplitConverter.CreateOpenXmlElement<DXDC.CustomSplit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetSecondPieSize(DXDC.OfPieChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.SecondPieSize>()?.Val);
  }
  
  private static bool CmpSecondPieSize(DXDC.OfPieChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.SecondPieSize>()?.Val, value, diffs, objName, "SecondPieSize");
  }
  
  private static void SetSecondPieSize(DXDC.OfPieChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.SecondPieSize,System.UInt16>(openXmlElement, value);
  }
  
  private static Collection<DMDC.SeriesLines>? GetSeriesLines(DXDC.OfPieChart openXmlElement)
  {
    var collection = new Collection<DMDC.SeriesLines>();
    foreach (var item in openXmlElement.Elements<DXDC.SeriesLines>())
    {
      var newItem = DMXDC.SeriesLinesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSeriesLines(DXDC.OfPieChart openXmlElement, Collection<DMDC.SeriesLines>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.SeriesLines>();
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
        if (!DMXDC.SeriesLinesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSeriesLines(DXDC.OfPieChart openXmlElement, Collection<DMDC.SeriesLines>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.SeriesLines>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.SeriesLinesConverter.CreateOpenXmlElement<DXDC.SeriesLines>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.OfPieChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.OfPieChart openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.OfPieChart openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.OfPieChart? CreateModelElement(DXDC.OfPieChart? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.OfPieChart? openXmlElement, DMDC.OfPieChart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.OfPieChart value)
    where OpenXmlElementType: DXDC.OfPieChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.OfPieChart openXmlElement, DMDC.OfPieChart value)
  {
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
  }
}
