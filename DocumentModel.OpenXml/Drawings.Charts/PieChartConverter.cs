namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
public static class PieChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.PieChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.PieChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.PieChartSeries> GetPieChartSerieses(DXDrawCharts.PieChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieChartSeries>())
    {
      var newItem = DMXDrawsCharts.PieChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPieChartSerieses(DXDrawCharts.PieChart openXmlElement, Collection<DMDrawsCharts.PieChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.PieChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.PieChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.PieChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.PieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.PieChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static UInt16? GetFirstSliceAngle(DXDrawCharts.PieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.FirstSliceAngle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFirstSliceAngle(DXDrawCharts.PieChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FirstSliceAngle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FirstSliceAngle{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PieChartExtensionList? GetPieChartExtensionList(DXDrawCharts.PieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PieChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.PieChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPieChartExtensionList(DXDrawCharts.PieChart openXmlElement, DMDrawsCharts.PieChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PieChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PieChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.PieChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.PieChart? CreateModelElement(DXDrawCharts.PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PieChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.FirstSliceAngle = GetFirstSliceAngle(openXmlElement);
      value.PieChartExtensionList = GetPieChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieChart? value)
    where OpenXmlElementType: DXDrawCharts.PieChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSerieses(openXmlElement, value?.PieChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetFirstSliceAngle(openXmlElement, value?.FirstSliceAngle);
      SetPieChartExtensionList(openXmlElement, value?.PieChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
