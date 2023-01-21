namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Label.
/// </summary>
public static class DataLabelConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DXDrawCharts.DataLabel openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Index{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDelete(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Delete>();
    return itemElement != null;
  }
  
  private static void SetDelete(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static DMDrawsCharts.Layout? GetLayout(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Layout>();
    if (itemElement != null)
      return DMXDrawsCharts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLayout(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.Layout? value)
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
  
  private static DMDrawsCharts.ChartText? GetChartText(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartText>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartText(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.ChartText? value)
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
  
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingFormat(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.NumberingFormat? value)
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
  
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.TextProperties? value)
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
  
  private static DMDrawsCharts.DataLabelPositionKind? GetDataLabelPosition(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabelPosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDataLabelPosition(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.DataLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabelPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowLegendKey(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowLegendKey>();
    return itemElement != null;
  }
  
  private static void SetShowLegendKey(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowValue(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowValue>();
    return itemElement != null;
  }
  
  private static void SetShowValue(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowCategoryName(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowCategoryName>();
    return itemElement != null;
  }
  
  private static void SetShowCategoryName(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowSeriesName(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowSeriesName>();
    return itemElement != null;
  }
  
  private static void SetShowSeriesName(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowPercent(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowPercent>();
    return itemElement != null;
  }
  
  private static void SetShowPercent(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowBubbleSize(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowBubbleSize>();
    return itemElement != null;
  }
  
  private static void SetShowBubbleSize(DXDrawCharts.DataLabel openXmlElement, Boolean? value)
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
  
  private static String? GetSeparator(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Separator>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetSeparator(DXDrawCharts.DataLabel openXmlElement, String? value)
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
  
  private static DMDrawsCharts.DLblExtensionList? GetDLblExtensionList(DXDrawCharts.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DLblExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.DLblExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDLblExtensionList(DXDrawCharts.DataLabel openXmlElement, DMDrawsCharts.DLblExtensionList? value)
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
  
  public static DMDrawsCharts.DataLabel? CreateModelElement(DXDrawCharts.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DataLabel();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabel? value)
    where OpenXmlElementType: DXDrawCharts.DataLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
