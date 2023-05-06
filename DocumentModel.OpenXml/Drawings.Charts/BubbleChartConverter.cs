namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public static class BubbleChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.BubbleChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.BubbleChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.BubbleChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.BubbleChartSeries>? GetBubbleChartSeries(DXDC.BubbleChart openXmlElement)
  {
    var collection = new Collection<DMDC.BubbleChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.BubbleChartSeries>())
    {
      var newItem = DMXDC.BubbleChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBubbleChartSeries(DXDC.BubbleChart openXmlElement, Collection<DMDC.BubbleChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.BubbleChartSeries>();
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
        if (!DMXDC.BubbleChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBubbleChartSeries(DXDC.BubbleChart openXmlElement, Collection<DMDC.BubbleChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.BubbleChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.BubbleChartSeriesConverter.CreateOpenXmlElement<DXDC.BubbleChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.BubbleChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.BubbleChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.BubbleChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static Boolean? GetBubble3D(DXDC.BubbleChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXDC.BubbleChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXDC.BubbleChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Bubble3D();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static UInt32? GetBubbleScale(DXDC.BubbleChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.BubbleScale>()?.Val);
  }
  
  private static bool CmpBubbleScale(DXDC.BubbleChart openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.BubbleScale>()?.Val, value, diffs, objName, "BubbleScale");
  }
  
  private static void SetBubbleScale(DXDC.BubbleChart openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.BubbleScale,System.UInt32>(openXmlElement, value);
  }
  
  private static Boolean? GetShowNegativeBubbles(DXDC.BubbleChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowNegativeBubbles>() != null;
  }
  
  private static bool CmpShowNegativeBubbles(DXDC.BubbleChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowNegativeBubbles>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowNegativeBubbles", val, value);
    return false;
  }
  
  private static void SetShowNegativeBubbles(DXDC.BubbleChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowNegativeBubbles>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowNegativeBubbles();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.SizeRepresentsKind? GetSizeRepresents(DXDC.BubbleChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>(openXmlElement.GetFirstChild<DXDC.SizeRepresents>()?.Val?.Value);
  }
  
  private static bool CmpSizeRepresents(DXDC.BubbleChart openXmlElement, DMDC.SizeRepresentsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>(openXmlElement.GetFirstChild<DXDC.SizeRepresents>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSizeRepresents(DXDC.BubbleChart openXmlElement, DMDC.SizeRepresentsKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SizeRepresents>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>(itemElement, (DMDC.SizeRepresentsKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.SizeRepresents, DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>((DMDC.SizeRepresentsKind)value));
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.BubbleChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.BubbleChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
  
  private static void SetAxisIds(DXDC.BubbleChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.BubbleChartExtensionList? GetBubbleChartExtensionList(DXDC.BubbleChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BubbleChartExtensionList>();
    if (element != null)
      return DMXDC.BubbleChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleChartExtensionList(DXDC.BubbleChart openXmlElement, DMDC.BubbleChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BubbleChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BubbleChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetBubbleChartExtensionList(DXDC.BubbleChart openXmlElement, DMDC.BubbleChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BubbleChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BubbleChartExtensionListConverter.CreateOpenXmlElement<DXDC.BubbleChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChart? CreateModelElement(DXDC.BubbleChart? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.BubbleChart? openXmlElement, DMDC.BubbleChart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BubbleChart value)
    where OpenXmlElementType: DXDC.BubbleChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BubbleChart openXmlElement, DMDC.BubbleChart value)
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
