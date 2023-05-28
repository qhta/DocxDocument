namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public static class ScatterChartConverter
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  private static DMDC.ScatterStyleKind? GetScatterStyle(DXDC.ScatterChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>(openXmlElement.GetFirstChild<DXDC.ScatterStyle>()?.Val?.Value);
  }
  
  private static bool CmpScatterStyle(DXDC.ScatterChart openXmlElement, DMDC.ScatterStyleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>(openXmlElement.GetFirstChild<DXDC.ScatterStyle>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetScatterStyle(DXDC.ScatterChart openXmlElement, DMDC.ScatterStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ScatterStyle>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>(itemElement, (DMDC.ScatterStyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ScatterStyle, DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>((DMDC.ScatterStyleKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.ScatterChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.ScatterChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.ScatterChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.ScatterChartSeries>? GetScatterChartSeries(DXDC.ScatterChart openXmlElement)
  {
    var collection = new Collection<DMDC.ScatterChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.ScatterChartSeries>())
    {
      var newItem = DMXDC.ScatterChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpScatterChartSeries(DXDC.ScatterChart openXmlElement, Collection<DMDC.ScatterChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.ScatterChartSeries>();
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
        if (!DMXDC.ScatterChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetScatterChartSeries(DXDC.ScatterChart openXmlElement, Collection<DMDC.ScatterChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.ScatterChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.ScatterChartSeriesConverter.CreateOpenXmlElement<DXDC.ScatterChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.ScatterChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.ScatterChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.ScatterChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static Collection<UInt32>? GetAxisIds(DXDC.ScatterChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.ScatterChart openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.AxisId>();
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
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAxisIds(DXDC.ScatterChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.ScatterChartExtensionList? GetScatterChartExtensionList(DXDC.ScatterChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ScatterChartExtensionList>();
    if (element != null)
      return DMXDC.ScatterChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScatterChartExtensionList(DXDC.ScatterChart openXmlElement, DMDC.ScatterChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ScatterChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ScatterChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetScatterChartExtensionList(DXDC.ScatterChart openXmlElement, DMDC.ScatterChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ScatterChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ScatterChartExtensionListConverter.CreateOpenXmlElement<DXDC.ScatterChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.ScatterChart? CreateModelElement(DXDC.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ScatterChart();
      value.ScatterStyle = GetScatterStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ScatterChartExtensionList = GetScatterChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ScatterChart? openXmlElement, DMDC.ScatterChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterStyle(openXmlElement, value.ScatterStyle, diffs, objName, propName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName, propName))
        ok = false;
      if (!CmpScatterChartSeries(openXmlElement, value.ScatterChartSeries, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName, propName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName, propName))
        ok = false;
      if (!CmpScatterChartExtensionList(openXmlElement, value.ScatterChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ScatterChart value)
    where OpenXmlElementType: DXDC.ScatterChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ScatterChart openXmlElement, DMDC.ScatterChart value)
  {
    SetScatterStyle(openXmlElement, value?.ScatterStyle);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetScatterChartExtensionList(openXmlElement, value?.ScatterChartExtensionList);
  }
}
