namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public static class BubbleChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.BubbleChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
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
  
  private static Collection<DMDrawsCharts.BubbleChartSeries> GetBubbleChartSerieses(DXDrawCharts.BubbleChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleChartSeries>())
    {
      var newItem = DMXDrawsCharts.BubbleChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBubbleChartSerieses(DXDrawCharts.BubbleChart openXmlElement, Collection<DMDrawsCharts.BubbleChartSeries>? value)
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BubbleScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBubbleScale(DXDrawCharts.BubbleChart openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BubbleScale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.BubbleScale{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowNegativeBubbles(DXDrawCharts.BubbleChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowNegativeBubbles>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SizeRepresents>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDrawsCharts.SizeRepresentsKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSizeRepresents(DXDrawCharts.BubbleChart openXmlElement, DMDrawsCharts.SizeRepresentsKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SizeRepresents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.SizeRepresents, DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDrawsCharts.SizeRepresentsKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.BubbleChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BubbleChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.BubbleChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.BubbleChart? CreateModelElement(DXDrawCharts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BubbleChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BubbleChartSerieses = GetBubbleChartSerieses(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChart? value)
    where OpenXmlElementType: DXDrawCharts.BubbleChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetBubbleChartSerieses(openXmlElement, value?.BubbleChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetBubbleScale(openXmlElement, value?.BubbleScale);
      SetShowNegativeBubbles(openXmlElement, value?.ShowNegativeBubbles);
      SetSizeRepresents(openXmlElement, value?.SizeRepresents);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetBubbleChartExtensionList(openXmlElement, value?.BubbleChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
