namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabel3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXO2013DrawChart.DataLabel openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXO2013DrawChart.DataLabel openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Index,System.UInt32>(openXmlElement, value);
  }
  
  private static Boolean? GetDelete(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
  }
  
  private static bool CmpDelete(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Delete>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Delete();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Layout? GetLayout(DXO2013DrawChart.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Layout>();
    if (element != null)
      return DMXDrawsCharts.LayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.Layout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Layout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayout(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.Layout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LayoutConverter.CreateOpenXmlElement<DXDrawCharts.Layout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ChartText? GetChartText(DXO2013DrawChart.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartText>();
    if (element != null)
      return DMXDrawsCharts.ChartTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.ChartText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartText(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.ChartText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartTextConverter.CreateOpenXmlElement<DXDrawCharts.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXO2013DrawChart.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (element != null)
      return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberingFormatConverter.CreateOpenXmlElement<DXDrawCharts.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXO2013DrawChart.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXO2013DrawChart.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (element != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TextPropertiesConverter.CreateOpenXmlElement<DXDrawCharts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DataLabelPositionKind? GetDataLabelPosition(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.DataLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpDataLabelPosition(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.DataLabelPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.DataLabelPosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabelPosition(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.DataLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabelPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>(itemElement, (DMDrawsCharts.DataLabelPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>((DMDrawsCharts.DataLabelPositionKind)value));
  }
  
  private static Boolean? GetShowLegendKey(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowLegendKey>() != null;
  }
  
  private static bool CmpShowLegendKey(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowLegendKey>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowLegendKey", val, value);
    return false;
  }
  
  private static void SetShowLegendKey(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowLegendKey>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowLegendKey();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowValue(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowValue>() != null;
  }
  
  private static bool CmpShowValue(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowValue>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowValue", val, value);
    return false;
  }
  
  private static void SetShowValue(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowValue>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowValue();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowCategoryName(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowCategoryName>() != null;
  }
  
  private static bool CmpShowCategoryName(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowCategoryName>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowCategoryName", val, value);
    return false;
  }
  
  private static void SetShowCategoryName(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowCategoryName>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowCategoryName();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowSeriesName(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowSeriesName>() != null;
  }
  
  private static bool CmpShowSeriesName(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowSeriesName>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowSeriesName", val, value);
    return false;
  }
  
  private static void SetShowSeriesName(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowSeriesName>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowSeriesName();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowPercent(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowPercent>() != null;
  }
  
  private static bool CmpShowPercent(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowPercent>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowPercent", val, value);
    return false;
  }
  
  private static void SetShowPercent(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowPercent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowPercent();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowBubbleSize(DXO2013DrawChart.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowBubbleSize>() != null;
  }
  
  private static bool CmpShowBubbleSize(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowBubbleSize>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowBubbleSize", val, value);
    return false;
  }
  
  private static void SetShowBubbleSize(DXO2013DrawChart.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowBubbleSize>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowBubbleSize();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetSeparator(DXO2013DrawChart.DataLabel openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Separator>()?.Text;
  }
  
  private static bool CmpSeparator(DXO2013DrawChart.DataLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Separator>()?.Text == value;
  }
  
  private static void SetSeparator(DXO2013DrawChart.DataLabel openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Separator { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DLblExtensionList? GetDLblExtensionList(DXO2013DrawChart.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DLblExtensionList>();
    if (element != null)
      return DMXDrawsCharts.DLblExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDLblExtensionList(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.DLblExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DLblExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DLblExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDLblExtensionList(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.DLblExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DLblExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DLblExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.DLblExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabel3? CreateModelElement(DXO2013DrawChart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabel3();
      value.Index = GetIndex(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.DataLabelPosition = GetDataLabelPosition(openXmlElement);
      value.ShowLegendKey = GetShowLegendKey(openXmlElement);
      value.ShowValue = GetShowValue(openXmlElement);
      value.ShowCategoryName = GetShowCategoryName(openXmlElement);
      value.ShowSeriesName = GetShowSeriesName(openXmlElement);
      value.ShowPercent = GetShowPercent(openXmlElement);
      value.ShowBubbleSize = GetShowBubbleSize(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.DLblExtensionList = GetDLblExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.DataLabel? openXmlElement, DMDrawsCharts.DataLabel3? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpDelete(openXmlElement, value.Delete, diffs, objName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpDataLabelPosition(openXmlElement, value.DataLabelPosition, diffs, objName))
        ok = false;
      if (!CmpShowLegendKey(openXmlElement, value.ShowLegendKey, diffs, objName))
        ok = false;
      if (!CmpShowValue(openXmlElement, value.ShowValue, diffs, objName))
        ok = false;
      if (!CmpShowCategoryName(openXmlElement, value.ShowCategoryName, diffs, objName))
        ok = false;
      if (!CmpShowSeriesName(openXmlElement, value.ShowSeriesName, diffs, objName))
        ok = false;
      if (!CmpShowPercent(openXmlElement, value.ShowPercent, diffs, objName))
        ok = false;
      if (!CmpShowBubbleSize(openXmlElement, value.ShowBubbleSize, diffs, objName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName))
        ok = false;
      if (!CmpDLblExtensionList(openXmlElement, value.DLblExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabel3 value)
    where OpenXmlElementType: DXO2013DrawChart.DataLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.DataLabel openXmlElement, DMDrawsCharts.DataLabel3 value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetDelete(openXmlElement, value?.Delete);
    SetLayout(openXmlElement, value?.Layout);
    SetChartText(openXmlElement, value?.ChartText);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetDataLabelPosition(openXmlElement, value?.DataLabelPosition);
    SetShowLegendKey(openXmlElement, value?.ShowLegendKey);
    SetShowValue(openXmlElement, value?.ShowValue);
    SetShowCategoryName(openXmlElement, value?.ShowCategoryName);
    SetShowSeriesName(openXmlElement, value?.ShowSeriesName);
    SetShowPercent(openXmlElement, value?.ShowPercent);
    SetShowBubbleSize(openXmlElement, value?.ShowBubbleSize);
    SetSeparator(openXmlElement, value?.Separator);
    SetDLblExtensionList(openXmlElement, value?.DLblExtensionList);
  }
}
