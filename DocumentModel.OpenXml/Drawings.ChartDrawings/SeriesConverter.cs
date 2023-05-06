namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public static class SeriesConverter
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.SeriesLayout? GetLayoutId(DXO16DCD.Series openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DMDCDs.SeriesLayout>(openXmlElement?.LayoutId?.Value);
  }
  
  private static bool CmpLayoutId(DXO16DCD.Series openXmlElement, DMDCDs.SeriesLayout? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DMDCDs.SeriesLayout>(openXmlElement?.LayoutId?.Value, value, diffs, objName);
  }
  
  private static void SetLayoutId(DXO16DCD.Series openXmlElement, DMDCDs.SeriesLayout? value)
  {
    openXmlElement.LayoutId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DMDCDs.SeriesLayout>(value);
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetHidden(DXO16DCD.Series openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXO16DCD.Series openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "GlyphHidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXO16DCD.Series openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetOwnerIdx(DXO16DCD.Series openXmlElement)
  {
    return openXmlElement?.OwnerIdx?.Value;
  }
  
  private static bool CmpOwnerIdx(DXO16DCD.Series openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OwnerIdx?.Value == value) return true;
    diffs?.Add(objName, "OwnerIdx", openXmlElement?.OwnerIdx?.Value, value);
    return false;
  }
  
  private static void SetOwnerIdx(DXO16DCD.Series openXmlElement, UInt32? value)
  {
    openXmlElement.OwnerIdx = value;
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUniqueId(DXO16DCD.Series openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXO16DCD.Series openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXO16DCD.Series openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetFormatIdx(DXO16DCD.Series openXmlElement)
  {
    return openXmlElement?.FormatIdx?.Value;
  }
  
  private static bool CmpFormatIdx(DXO16DCD.Series openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FormatIdx?.Value == value) return true;
    diffs?.Add(objName, "FormatIdx", openXmlElement?.FormatIdx?.Value, value);
    return false;
  }
  
  private static void SetFormatIdx(DXO16DCD.Series openXmlElement, UInt32? value)
  {
    openXmlElement.FormatIdx = value;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static DMDCDs.Text? GetText(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Text>();
    if (element != null)
      return DMXDCDs.TextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpText(DXO16DCD.Series openXmlElement, DMDCDs.Text? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.TextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Text>(), value, diffs, objName);
  }
  
  private static void SetText(DXO16DCD.Series openXmlElement, DMDCDs.Text? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.TextConverter.CreateOpenXmlElement<DXO16DCD.Text>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.Series openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO16DCD.Series openXmlElement, DMDCDs.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  private static DMDCDs.ValueColors? GetValueColors(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ValueColors>();
    if (element != null)
      return DMXDCDs.ValueColorsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueColors(DXO16DCD.Series openXmlElement, DMDCDs.ValueColors? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ValueColorsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ValueColors>(), value, diffs, objName);
  }
  
  private static void SetValueColors(DXO16DCD.Series openXmlElement, DMDCDs.ValueColors? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ValueColors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ValueColorsConverter.CreateOpenXmlElement<DXO16DCD.ValueColors>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  private static DMDCDs.ValueColorPositions? GetValueColorPositions(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ValueColorPositions>();
    if (element != null)
      return DMXDCDs.ValueColorPositionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueColorPositions(DXO16DCD.Series openXmlElement, DMDCDs.ValueColorPositions? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ValueColorPositionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ValueColorPositions>(), value, diffs, objName);
  }
  
  private static void SetValueColorPositions(DXO16DCD.Series openXmlElement, DMDCDs.ValueColorPositions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ValueColorPositions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ValueColorPositionsConverter.CreateOpenXmlElement<DXO16DCD.ValueColorPositions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDCDs.DataPoint>? GetDataPoints(DXO16DCD.Series openXmlElement)
  {
    var collection = new Collection<DMDCDs.DataPoint>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.DataPoint>())
    {
      var newItem = DMXDCDs.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataPoints(DXO16DCD.Series openXmlElement, Collection<DMDCDs.DataPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.DataPoint>();
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
        if (!DMXDCDs.DataPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataPoints(DXO16DCD.Series openXmlElement, Collection<DMDCDs.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.DataPointConverter.CreateOpenXmlElement<DXO16DCD.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDCDs.DataLabels? GetDataLabels(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.DataLabels>();
    if (element != null)
      return DMXDCDs.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXO16DCD.Series openXmlElement, DMDCDs.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXO16DCD.Series openXmlElement, DMDCDs.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.DataLabelsConverter.CreateOpenXmlElement<DXO16DCD.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static UInt32? GetDataId(DXO16DCD.Series openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO16DCD.DataId>()?.Val);
  }
  
  private static bool CmpDataId(DXO16DCD.Series openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO16DCD.DataId>()?.Val, value, diffs, objName, "DataId");
  }
  
  private static void SetDataId(DXO16DCD.Series openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXO16DCD.DataId,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDCDs.SeriesLayoutProperties? GetSeriesLayoutProperties(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.SeriesLayoutProperties>();
    if (element != null)
      return DMXDCDs.SeriesLayoutPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesLayoutProperties(DXO16DCD.Series openXmlElement, DMDCDs.SeriesLayoutProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.SeriesLayoutPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.SeriesLayoutProperties>(), value, diffs, objName);
  }
  
  private static void SetSeriesLayoutProperties(DXO16DCD.Series openXmlElement, DMDCDs.SeriesLayoutProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.SeriesLayoutProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.SeriesLayoutPropertiesConverter.CreateOpenXmlElement<DXO16DCD.SeriesLayoutProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<String>? GetAxisIds(DXO16DCD.Series openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.AxisId>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXO16DCD.Series openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.AxisId>();
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
  
  private static void SetAxisIds(DXO16DCD.Series openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXO16DCD.AxisId>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.Series openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.Series openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.Series openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Series? CreateModelElement(DXO16DCD.Series? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.Series? openXmlElement, DMDCDs.Series? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Series value)
    where OpenXmlElementType: DXO16DCD.Series, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Series openXmlElement, DMDCDs.Series value)
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
