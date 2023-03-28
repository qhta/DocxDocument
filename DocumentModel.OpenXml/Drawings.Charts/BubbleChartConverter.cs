namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bubble Charts converter from/to OpenXml.
///</summary>
public static class BubbleChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.BubbleChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.BubbleChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDrawCharts.BubbleChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.BubbleChartSeries>? GetBubbleChartSeries(DXDrawCharts.BubbleChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleChartSeries>())
    {
      var newItem = DMXDrawsCharts.BubbleChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBubbleChartSeries(DXDrawCharts.BubbleChart openXmlElement, Collection<DMDrawsCharts.BubbleChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.BubbleChartSeries>();
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
        if (!DMXDrawsCharts.BubbleChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBubbleChartSeries(DXDrawCharts.BubbleChart openXmlElement, Collection<DMDrawsCharts.BubbleChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BubbleChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BubbleChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.BubbleChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.BubbleChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Boolean? GetBubble3D(DXDrawCharts.BubbleChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXDrawCharts.BubbleChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXDrawCharts.BubbleChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetBubbleScale(DXDrawCharts.BubbleChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.BubbleScale>()?.Val);
  }
  
  private static bool CmpBubbleScale(DXDrawCharts.BubbleChart openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.BubbleScale>()?.Val, value, diffs, objName, "BubbleScale");
  }
  
  private static void SetBubbleScale(DXDrawCharts.BubbleChart openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.BubbleScale,System.UInt32>(openXmlElement, value);
  }
  
  private static Boolean? GetShowNegativeBubbles(DXDrawCharts.BubbleChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowNegativeBubbles>() != null;
  }
  
  private static bool CmpShowNegativeBubbles(DXDrawCharts.BubbleChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowNegativeBubbles>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowNegativeBubbles", val, value);
    return false;
  }
  
  private static void SetShowNegativeBubbles(DXDrawCharts.BubbleChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowNegativeBubbles>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowNegativeBubbles();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.SizeRepresentsKind? GetSizeRepresents(DXDrawCharts.BubbleChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDrawsCharts.SizeRepresentsKind>(openXmlElement.GetFirstChild<DXDrawCharts.SizeRepresents>()?.Val?.Value);
  }
  
  private static bool CmpSizeRepresents(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.SizeRepresentsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDrawsCharts.SizeRepresentsKind>(openXmlElement.GetFirstChild<DXDrawCharts.SizeRepresents>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSizeRepresents(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.SizeRepresentsKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SizeRepresents>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDrawsCharts.SizeRepresentsKind>(itemElement, (DMDrawsCharts.SizeRepresentsKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.SizeRepresents, DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDrawsCharts.SizeRepresentsKind>((DMDrawsCharts.SizeRepresentsKind)value));
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.BubbleChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXDrawCharts.BubbleChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.AxisId>();
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
  
  private static void SetAxisIds(DXDrawCharts.BubbleChart openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDrawCharts.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.BubbleChartExtensionList? GetBubbleChartExtensionList(DXDrawCharts.BubbleChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.BubbleChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.BubbleChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleChartExtensionList(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.BubbleChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BubbleChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.BubbleChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetBubbleChartExtensionList(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.BubbleChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BubbleChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BubbleChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.BubbleChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChart? CreateModelElement(DXDrawCharts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BubbleChartSeries = GetBubbleChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.BubbleScale = GetBubbleScale(openXmlElement);
      value.ShowNegativeBubbles = GetShowNegativeBubbles(openXmlElement);
      value.SizeRepresents = GetSizeRepresents(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.BubbleChartExtensionList = GetBubbleChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BubbleChart? openXmlElement, DMDrawsCharts.BubbleChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpBubbleChartSeries(openXmlElement, value.BubbleChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpBubble3D(openXmlElement, value.Bubble3D, diffs, objName))
        ok = false;
      if (!CmpBubbleScale(openXmlElement, value.BubbleScale, diffs, objName))
        ok = false;
      if (!CmpShowNegativeBubbles(openXmlElement, value.ShowNegativeBubbles, diffs, objName))
        ok = false;
      if (!CmpSizeRepresents(openXmlElement, value.SizeRepresents, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpBubbleChartExtensionList(openXmlElement, value.BubbleChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChart value)
    where OpenXmlElementType: DXDrawCharts.BubbleChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.BubbleChart value)
  {
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetBubbleChartSeries(openXmlElement, value?.BubbleChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetBubble3D(openXmlElement, value?.Bubble3D);
    SetBubbleScale(openXmlElement, value?.BubbleScale);
    SetShowNegativeBubbles(openXmlElement, value?.ShowNegativeBubbles);
    SetSizeRepresents(openXmlElement, value?.SizeRepresents);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetBubbleChartExtensionList(openXmlElement, value?.BubbleChartExtensionList);
  }
}
