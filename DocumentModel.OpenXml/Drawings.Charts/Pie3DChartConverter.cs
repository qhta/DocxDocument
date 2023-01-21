namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public static class Pie3DChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.Pie3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.Pie3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.PieChartSeries> GetPieChartSerieses(DXDrawCharts.Pie3DChart openXmlElement)
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
  
  private static void SetPieChartSerieses(DXDrawCharts.Pie3DChart openXmlElement, Collection<DMDrawsCharts.PieChartSeries>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.Pie3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.Pie3DChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static DMDrawsCharts.Pie3DChartExtensionList? GetPie3DChartExtensionList(DXDrawCharts.Pie3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Pie3DChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.Pie3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPie3DChartExtensionList(DXDrawCharts.Pie3DChart openXmlElement, DMDrawsCharts.Pie3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Pie3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Pie3DChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.Pie3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Pie3DChart? CreateModelElement(DXDrawCharts.Pie3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Pie3DChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Pie3DChartExtensionList = GetPie3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Pie3DChart? value)
    where OpenXmlElementType: DXDrawCharts.Pie3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSerieses(openXmlElement, value?.PieChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetPie3DChartExtensionList(openXmlElement, value?.Pie3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
