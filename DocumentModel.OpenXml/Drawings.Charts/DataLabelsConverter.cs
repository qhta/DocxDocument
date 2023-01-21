namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Labels.
/// </summary>
public static class DataLabelsConverter
{
  private static Collection<DMDrawsCharts.DataLabel> GetItems(DXDrawCharts.DataLabels openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataLabel>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DataLabel>())
    {
      var newItem = DMXDrawsCharts.DataLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXDrawCharts.DataLabels openXmlElement, Collection<DMDrawsCharts.DataLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DataLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DataLabelConverter.CreateOpenXmlElement<DXDrawCharts.DataLabel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Boolean? GetDelete(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Delete>();
    return itemElement != null;
  }
  
  private static void SetDelete(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingFormat(DXDrawCharts.DataLabels openXmlElement, DMDrawsCharts.NumberingFormat? value)
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
  
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.DataLabels openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DXDrawCharts.DataLabels openXmlElement, DMDrawsCharts.TextProperties? value)
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
  
  private static DMDrawsCharts.DataLabelPositionKind? GetDataLabelPosition(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabelPosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDrawsCharts.DataLabelPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDataLabelPosition(DXDrawCharts.DataLabels openXmlElement, DMDrawsCharts.DataLabelPositionKind? value)
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
  
  private static Boolean? GetShowLegendKey(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowLegendKey>();
    return itemElement != null;
  }
  
  private static void SetShowLegendKey(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowValue(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowValue>();
    return itemElement != null;
  }
  
  private static void SetShowValue(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowCategoryName(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowCategoryName>();
    return itemElement != null;
  }
  
  private static void SetShowCategoryName(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowSeriesName(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowSeriesName>();
    return itemElement != null;
  }
  
  private static void SetShowSeriesName(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowPercent(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowPercent>();
    return itemElement != null;
  }
  
  private static void SetShowPercent(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowBubbleSize(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowBubbleSize>();
    return itemElement != null;
  }
  
  private static void SetShowBubbleSize(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
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
  
  private static String? GetSeparator(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Separator>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetSeparator(DXDrawCharts.DataLabels openXmlElement, String? value)
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
  
  private static Boolean? GetShowLeaderLines(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowLeaderLines>();
    return itemElement != null;
  }
  
  private static void SetShowLeaderLines(DXDrawCharts.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowLeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowLeaderLines();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.LeaderLines? GetLeaderLines(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.LeaderLines>();
    if (itemElement != null)
      return DMXDrawsCharts.LeaderLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeaderLines(DXDrawCharts.DataLabels openXmlElement, DMDrawsCharts.LeaderLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LeaderLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LeaderLinesConverter.CreateOpenXmlElement<DXDrawCharts.LeaderLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DLblsExtensionList? GetDLblsExtensionList(DXDrawCharts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DLblsExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.DLblsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDLblsExtensionList(DXDrawCharts.DataLabels openXmlElement, DMDrawsCharts.DLblsExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DLblsExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DLblsExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.DLblsExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.DataLabels? CreateModelElement(DXDrawCharts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DataLabels();
      value.Items = GetItems(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
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
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      value.DLblsExtensionList = GetDLblsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabels? value)
    where OpenXmlElementType: DXDrawCharts.DataLabels, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      SetDelete(openXmlElement, value?.Delete);
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
      SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
      SetLeaderLines(openXmlElement, value?.LeaderLines);
      SetDLblsExtensionList(openXmlElement, value?.DLblsExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
