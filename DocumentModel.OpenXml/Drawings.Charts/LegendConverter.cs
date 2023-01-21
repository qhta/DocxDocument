namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  private static DMDrawsCharts.LegendPositionKind? GetLegendPosition(DXDrawCharts.Legend openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LegendPosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DMDrawsCharts.LegendPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLegendPosition(DXDrawCharts.Legend openXmlElement, DMDrawsCharts.LegendPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LegendPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LegendPosition, DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DMDrawsCharts.LegendPositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.LegendEntry> GetLegendEntries(DXDrawCharts.Legend openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.LegendEntry>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.LegendEntry>())
    {
      var newItem = DMXDrawsCharts.LegendEntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLegendEntries(DXDrawCharts.Legend openXmlElement, Collection<DMDrawsCharts.LegendEntry>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.LegendEntry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.LegendEntryConverter.CreateOpenXmlElement<DXDrawCharts.LegendEntry>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.Layout? GetLayout(DXDrawCharts.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Layout>();
    if (itemElement != null)
      return DMXDrawsCharts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLayout(DXDrawCharts.Legend openXmlElement, DMDrawsCharts.Layout? value)
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
  
  private static Boolean? GetOverlay(DXDrawCharts.Legend openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Overlay>();
    return itemElement != null;
  }
  
  private static void SetOverlay(DXDrawCharts.Legend openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Overlay>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Overlay();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.Legend openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DXDrawCharts.Legend openXmlElement, DMDrawsCharts.TextProperties? value)
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
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.Legend openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Legend? CreateModelElement(DXDrawCharts.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Legend();
      value.LegendPosition = GetLegendPosition(openXmlElement);
      value.LegendEntries = GetLegendEntries(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Legend? value)
    where OpenXmlElementType: DXDrawCharts.Legend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLegendPosition(openXmlElement, value?.LegendPosition);
      SetLegendEntries(openXmlElement, value?.LegendEntries);
      SetLayout(openXmlElement, value?.Layout);
      SetOverlay(openXmlElement, value?.Overlay);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
