namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public static class SeriesConverter
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.SeriesLayout? GetLayoutId(DXO2016DrawChartDraw.Series openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DMDrawsChartDraws.SeriesLayout>(openXmlElement?.LayoutId?.Value);
  }
  
  private static bool CmpLayoutId(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.SeriesLayout? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DMDrawsChartDraws.SeriesLayout>(openXmlElement?.LayoutId?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutId(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.SeriesLayout? value)
  {
    openXmlElement.LayoutId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DMDrawsChartDraws.SeriesLayout>(value);
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetHidden(DXO2016DrawChartDraw.Series openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXO2016DrawChartDraw.Series openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "Hidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXO2016DrawChartDraw.Series openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetOwnerIdx(DXO2016DrawChartDraw.Series openXmlElement)
  {
    return openXmlElement?.OwnerIdx?.Value;
  }
  
  private static bool CmpOwnerIdx(DXO2016DrawChartDraw.Series openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OwnerIdx?.Value == value) return true;
    diffs?.Add(objName, "OwnerIdx", openXmlElement?.OwnerIdx?.Value, value);
    return false;
  }
  
  private static void SetOwnerIdx(DXO2016DrawChartDraw.Series openXmlElement, UInt32? value)
  {
    openXmlElement.OwnerIdx = value;
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUniqueId(DXO2016DrawChartDraw.Series openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXO2016DrawChartDraw.Series openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXO2016DrawChartDraw.Series openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetFormatIdx(DXO2016DrawChartDraw.Series openXmlElement)
  {
    return openXmlElement?.FormatIdx?.Value;
  }
  
  private static bool CmpFormatIdx(DXO2016DrawChartDraw.Series openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FormatIdx?.Value == value) return true;
    diffs?.Add(objName, "FormatIdx", openXmlElement?.FormatIdx?.Value, value);
    return false;
  }
  
  private static void SetFormatIdx(DXO2016DrawChartDraw.Series openXmlElement, UInt32? value)
  {
    openXmlElement.FormatIdx = value;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static DMDrawsChartDraws.Text? GetText(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Text>();
    if (element != null)
      return DMXDrawsChartDraws.TextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpText(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.Text? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Text>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetText(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.Text? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TextConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Text>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  private static DMDrawsChartDraws.ValueColors? GetValueColors(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ValueColors>();
    if (element != null)
      return DMXDrawsChartDraws.ValueColorsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueColors(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ValueColors? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ValueColorsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueColors>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetValueColors(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ValueColors? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueColors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ValueColorsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ValueColors>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  private static DMDrawsChartDraws.ValueColorPositions? GetValueColorPositions(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ValueColorPositions>();
    if (element != null)
      return DMXDrawsChartDraws.ValueColorPositionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueColorPositions(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ValueColorPositions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ValueColorPositionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueColorPositions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetValueColorPositions(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ValueColorPositions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueColorPositions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ValueColorPositionsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ValueColorPositions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsChartDraws.DataPoint>? GetDataPoints(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.DataPoint>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.DataPoint>())
    {
      var newItem = DMXDrawsChartDraws.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataPoints(DXO2016DrawChartDraw.Series openXmlElement, Collection<DMDrawsChartDraws.DataPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.DataPoint>();
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
        if (!DMXDrawsChartDraws.DataPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataPoints(DXO2016DrawChartDraw.Series openXmlElement, Collection<DMDrawsChartDraws.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.DataPointConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.DataLabels? GetDataLabels(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.DataLabels>();
    if (element != null)
      return DMXDrawsChartDraws.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabels(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.DataLabelsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetDataId(DXO2016DrawChartDraw.Series openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.DataId>()?.Val);
  }
  
  private static bool CmpDataId(DXO2016DrawChartDraw.Series openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.DataId>()?.Val, value, diffs, objName, "DataId");
  }
  
  private static void SetDataId(DXO2016DrawChartDraw.Series openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.DataId,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDrawsChartDraws.SeriesLayoutProperties? GetSeriesLayoutProperties(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.SeriesLayoutProperties>();
    if (element != null)
      return DMXDrawsChartDraws.SeriesLayoutPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesLayoutProperties(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.SeriesLayoutProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.SeriesLayoutPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.SeriesLayoutProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSeriesLayoutProperties(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.SeriesLayoutProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.SeriesLayoutProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.SeriesLayoutPropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.SeriesLayoutProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<String>? GetAxisIds(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.AxisId>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXO2016DrawChartDraw.Series openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.AxisId>();
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
        if (!StringValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAxisIds(DXO2016DrawChartDraw.Series openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Series? CreateModelElement(DXO2016DrawChartDraw.Series? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Series();
      value.LayoutId = GetLayoutId(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.OwnerIdx = GetOwnerIdx(openXmlElement);
      value.UniqueId = GetUniqueId(openXmlElement);
      value.FormatIdx = GetFormatIdx(openXmlElement);
      value.Text = GetText(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ValueColors = GetValueColors(openXmlElement);
      value.ValueColorPositions = GetValueColorPositions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DataId = GetDataId(openXmlElement);
      value.SeriesLayoutProperties = GetSeriesLayoutProperties(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Series? openXmlElement, DMDrawsChartDraws.Series? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLayoutId(openXmlElement, value.LayoutId, diffs, objName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName))
        ok = false;
      if (!CmpOwnerIdx(openXmlElement, value.OwnerIdx, diffs, objName))
        ok = false;
      if (!CmpUniqueId(openXmlElement, value.UniqueId, diffs, objName))
        ok = false;
      if (!CmpFormatIdx(openXmlElement, value.FormatIdx, diffs, objName))
        ok = false;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpValueColors(openXmlElement, value.ValueColors, diffs, objName))
        ok = false;
      if (!CmpValueColorPositions(openXmlElement, value.ValueColorPositions, diffs, objName))
        ok = false;
      if (!CmpDataPoints(openXmlElement, value.DataPoints, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpDataId(openXmlElement, value.DataId, diffs, objName))
        ok = false;
      if (!CmpSeriesLayoutProperties(openXmlElement, value.SeriesLayoutProperties, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Series value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Series, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Series openXmlElement, DMDrawsChartDraws.Series value)
  {
    SetLayoutId(openXmlElement, value?.LayoutId);
    SetHidden(openXmlElement, value?.Hidden);
    SetOwnerIdx(openXmlElement, value?.OwnerIdx);
    SetUniqueId(openXmlElement, value?.UniqueId);
    SetFormatIdx(openXmlElement, value?.FormatIdx);
    SetText(openXmlElement, value?.Text);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetValueColors(openXmlElement, value?.ValueColors);
    SetValueColorPositions(openXmlElement, value?.ValueColorPositions);
    SetDataPoints(openXmlElement, value?.DataPoints);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetDataId(openXmlElement, value?.DataId);
    SetSeriesLayoutProperties(openXmlElement, value?.SeriesLayoutProperties);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
