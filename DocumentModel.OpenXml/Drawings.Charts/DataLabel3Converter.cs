namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabel3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO13DC.DataLabel openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXO13DC.DataLabel openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXO13DC.DataLabel openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  private static Boolean? GetDelete(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Delete>() != null;
  }
  
  private static bool CmpDelete(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Delete>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Delete();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Layout? GetLayout(DXO13DC.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Layout>();
    if (element != null)
      return DMXDC.LayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXO13DC.DataLabel openXmlElement, DMDC.Layout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.LayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Layout>(), value, diffs, objName, propName);
  }
  
  private static void SetLayout(DXO13DC.DataLabel openXmlElement, DMDC.Layout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LayoutConverter.CreateOpenXmlElement<DXDC.Layout>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ChartText? GetChartText(DXO13DC.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartText>();
    if (element != null)
      return DMXDC.ChartTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXO13DC.DataLabel openXmlElement, DMDC.ChartText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartText>(), value, diffs, objName, propName);
  }
  
  private static void SetChartText(DXO13DC.DataLabel openXmlElement, DMDC.ChartText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartTextConverter.CreateOpenXmlElement<DXDC.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.NumberingFormat? GetNumberingFormat(DXO13DC.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberingFormat>();
    if (element != null)
      return DMXDC.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXO13DC.DataLabel openXmlElement, DMDC.NumberingFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberingFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberingFormat(DXO13DC.DataLabel openXmlElement, DMDC.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberingFormatConverter.CreateOpenXmlElement<DXDC.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXO13DC.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXO13DC.DataLabel openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXO13DC.DataLabel openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.TextProperties? GetTextProperties(DXO13DC.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXO13DC.DataLabel openXmlElement, DMDC.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXO13DC.DataLabel openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DataLabelPositionKind? GetDataLabelPosition(DXO13DC.DataLabel openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.DataLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpDataLabelPosition(DXO13DC.DataLabel openXmlElement, DMDC.DataLabelPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.DataLabelPosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDataLabelPosition(DXO13DC.DataLabel openXmlElement, DMDC.DataLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabelPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(itemElement, (DMDC.DataLabelPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>((DMDC.DataLabelPositionKind)value));
  }
  
  private static Boolean? GetShowLegendKey(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowLegendKey>() != null;
  }
  
  private static bool CmpShowLegendKey(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowLegendKey>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowLegendKey", val, value);
    return false;
  }
  
  private static void SetShowLegendKey(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowLegendKey>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowLegendKey();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowValue(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowValue>() != null;
  }
  
  private static bool CmpShowValue(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowValue>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowValue", val, value);
    return false;
  }
  
  private static void SetShowValue(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowValue>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowValue();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowCategoryName(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowCategoryName>() != null;
  }
  
  private static bool CmpShowCategoryName(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowCategoryName>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowCategoryName", val, value);
    return false;
  }
  
  private static void SetShowCategoryName(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowCategoryName>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowCategoryName();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowSeriesName(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowSeriesName>() != null;
  }
  
  private static bool CmpShowSeriesName(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowSeriesName>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowSeriesName", val, value);
    return false;
  }
  
  private static void SetShowSeriesName(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowSeriesName>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowSeriesName();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowPercent(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowPercent>() != null;
  }
  
  private static bool CmpShowPercent(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowPercent>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowPercent", val, value);
    return false;
  }
  
  private static void SetShowPercent(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowPercent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowPercent();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowBubbleSize(DXO13DC.DataLabel openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowBubbleSize>() != null;
  }
  
  private static bool CmpShowBubbleSize(DXO13DC.DataLabel openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowBubbleSize>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowBubbleSize", val, value);
    return false;
  }
  
  private static void SetShowBubbleSize(DXO13DC.DataLabel openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowBubbleSize>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowBubbleSize();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetSeparator(DXO13DC.DataLabel openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.Separator>()?.Text;
  }
  
  private static bool CmpSeparator(DXO13DC.DataLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.Separator>()?.Text == value;
  }
  
  private static void SetSeparator(DXO13DC.DataLabel openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.Separator { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DLblExtensionList? GetDLblExtensionList(DXO13DC.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DLblExtensionList>();
    if (element != null)
      return DMXDC.DLblExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDLblExtensionList(DXO13DC.DataLabel openXmlElement, DMDC.DLblExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DLblExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DLblExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetDLblExtensionList(DXO13DC.DataLabel openXmlElement, DMDC.DLblExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DLblExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DLblExtensionListConverter.CreateOpenXmlElement<DXDC.DLblExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabel3? CreateModelElement(DXO13DC.DataLabel? openXmlElement)
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
  
  public static bool CompareModelElement(DXO13DC.DataLabel? openXmlElement, DMDC.DataLabel3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
      if (!CmpDelete(openXmlElement, value.Delete, diffs, objName, propName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName, propName))
        ok = false;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelPosition(openXmlElement, value.DataLabelPosition, diffs, objName, propName))
        ok = false;
      if (!CmpShowLegendKey(openXmlElement, value.ShowLegendKey, diffs, objName, propName))
        ok = false;
      if (!CmpShowValue(openXmlElement, value.ShowValue, diffs, objName, propName))
        ok = false;
      if (!CmpShowCategoryName(openXmlElement, value.ShowCategoryName, diffs, objName, propName))
        ok = false;
      if (!CmpShowSeriesName(openXmlElement, value.ShowSeriesName, diffs, objName, propName))
        ok = false;
      if (!CmpShowPercent(openXmlElement, value.ShowPercent, diffs, objName, propName))
        ok = false;
      if (!CmpShowBubbleSize(openXmlElement, value.ShowBubbleSize, diffs, objName, propName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName, propName))
        ok = false;
      if (!CmpDLblExtensionList(openXmlElement, value.DLblExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataLabel3 value)
    where OpenXmlElementType: DXO13DC.DataLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.DataLabel openXmlElement, DMDC.DataLabel3 value)
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
