namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  /// Layout.
  /// </summary>
  private static DMDrawsCharts.Layout? GetLayout(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Layout>();
    if (itemElement != null)
      return DMXDrawsCharts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLayout(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Layout? value)
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
  
  private static DMDrawsCharts.AreaChart? GetAreaChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.AreaChart>();
    if (itemElement != null)
      return DMXDrawsCharts.AreaChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAreaChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.AreaChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AreaChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.AreaChartConverter.CreateOpenXmlElement<DXDrawCharts.AreaChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Area3DChart? GetArea3DChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Area3DChart>();
    if (itemElement != null)
      return DMXDrawsCharts.Area3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArea3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Area3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Area3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Area3DChartConverter.CreateOpenXmlElement<DXDrawCharts.Area3DChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.LineChart? GetLineChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.LineChart>();
    if (itemElement != null)
      return DMXDrawsCharts.LineChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.LineChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LineChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LineChartConverter.CreateOpenXmlElement<DXDrawCharts.LineChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Line3DChart? GetLine3DChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Line3DChart>();
    if (itemElement != null)
      return DMXDrawsCharts.Line3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Line3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Line3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Line3DChartConverter.CreateOpenXmlElement<DXDrawCharts.Line3DChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.StockChart? GetStockChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StockChart>();
    if (itemElement != null)
      return DMXDrawsCharts.StockChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStockChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.StockChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StockChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StockChartConverter.CreateOpenXmlElement<DXDrawCharts.StockChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.RadarChart? GetRadarChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.RadarChart>();
    if (itemElement != null)
      return DMXDrawsCharts.RadarChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadarChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.RadarChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RadarChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RadarChartConverter.CreateOpenXmlElement<DXDrawCharts.RadarChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ScatterChart? GetScatterChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ScatterChart>();
    if (itemElement != null)
      return DMXDrawsCharts.ScatterChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScatterChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ScatterChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScatterChartConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PieChart? GetPieChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PieChart>();
    if (itemElement != null)
      return DMXDrawsCharts.PieChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPieChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.PieChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PieChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PieChartConverter.CreateOpenXmlElement<DXDrawCharts.PieChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Pie3DChart? GetPie3DChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Pie3DChart>();
    if (itemElement != null)
      return DMXDrawsCharts.Pie3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPie3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Pie3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Pie3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Pie3DChartConverter.CreateOpenXmlElement<DXDrawCharts.Pie3DChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DoughnutChart? GetDoughnutChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DoughnutChart>();
    if (itemElement != null)
      return DMXDrawsCharts.DoughnutChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDoughnutChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.DoughnutChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DoughnutChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DoughnutChartConverter.CreateOpenXmlElement<DXDrawCharts.DoughnutChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.BarChart? GetBarChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BarChart>();
    if (itemElement != null)
      return DMXDrawsCharts.BarChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBarChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.BarChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BarChartConverter.CreateOpenXmlElement<DXDrawCharts.BarChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Bar3DChart? GetBar3DChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Bar3DChart>();
    if (itemElement != null)
      return DMXDrawsCharts.Bar3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBar3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Bar3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bar3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Bar3DChartConverter.CreateOpenXmlElement<DXDrawCharts.Bar3DChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.OfPieChart? GetOfPieChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.OfPieChart>();
    if (itemElement != null)
      return DMXDrawsCharts.OfPieChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfPieChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.OfPieChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.OfPieChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.OfPieChartConverter.CreateOpenXmlElement<DXDrawCharts.OfPieChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.SurfaceChart? GetSurfaceChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceChart>();
    if (itemElement != null)
      return DMXDrawsCharts.SurfaceChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurfaceChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.SurfaceChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SurfaceChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SurfaceChartConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Surface3DChart? GetSurface3DChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Surface3DChart>();
    if (itemElement != null)
      return DMXDrawsCharts.Surface3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurface3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Surface3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Surface3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Surface3DChartConverter.CreateOpenXmlElement<DXDrawCharts.Surface3DChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.BubbleChart? GetBubbleChart(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BubbleChart>();
    if (itemElement != null)
      return DMXDrawsCharts.BubbleChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBubbleChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.BubbleChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BubbleChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BubbleChartConverter.CreateOpenXmlElement<DXDrawCharts.BubbleChart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ValueAxis? GetValueAxis(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ValueAxis>();
    if (itemElement != null)
      return DMXDrawsCharts.ValueAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValueAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ValueAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ValueAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ValueAxisConverter.CreateOpenXmlElement<DXDrawCharts.ValueAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.CategoryAxis? GetCategoryAxis(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxis>();
    if (itemElement != null)
      return DMXDrawsCharts.CategoryAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.CategoryAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CategoryAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.CategoryAxisConverter.CreateOpenXmlElement<DXDrawCharts.CategoryAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DateAxis? GetDateAxis(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DateAxis>();
    if (itemElement != null)
      return DMXDrawsCharts.DateAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDateAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.DateAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DateAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DateAxisConverter.CreateOpenXmlElement<DXDrawCharts.DateAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.SeriesAxis? GetSeriesAxis(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SeriesAxis>();
    if (itemElement != null)
      return DMXDrawsCharts.SeriesAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.SeriesAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SeriesAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SeriesAxisConverter.CreateOpenXmlElement<DXDrawCharts.SeriesAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DataTable? GetDataTable(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataTable>();
    if (itemElement != null)
      return DMXDrawsCharts.DataTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataTable(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.DataTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataTableConverter.CreateOpenXmlElement<DXDrawCharts.DataTable>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.PlotArea? CreateModelElement(DXDrawCharts.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PlotArea();
      value.Layout = GetLayout(openXmlElement);
      value.AreaChart = GetAreaChart(openXmlElement);
      value.Area3DChart = GetArea3DChart(openXmlElement);
      value.LineChart = GetLineChart(openXmlElement);
      value.Line3DChart = GetLine3DChart(openXmlElement);
      value.StockChart = GetStockChart(openXmlElement);
      value.RadarChart = GetRadarChart(openXmlElement);
      value.ScatterChart = GetScatterChart(openXmlElement);
      value.PieChart = GetPieChart(openXmlElement);
      value.Pie3DChart = GetPie3DChart(openXmlElement);
      value.DoughnutChart = GetDoughnutChart(openXmlElement);
      value.BarChart = GetBarChart(openXmlElement);
      value.Bar3DChart = GetBar3DChart(openXmlElement);
      value.OfPieChart = GetOfPieChart(openXmlElement);
      value.SurfaceChart = GetSurfaceChart(openXmlElement);
      value.Surface3DChart = GetSurface3DChart(openXmlElement);
      value.BubbleChart = GetBubbleChart(openXmlElement);
      value.ValueAxis = GetValueAxis(openXmlElement);
      value.CategoryAxis = GetCategoryAxis(openXmlElement);
      value.DateAxis = GetDateAxis(openXmlElement);
      value.SeriesAxis = GetSeriesAxis(openXmlElement);
      value.DataTable = GetDataTable(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PlotArea? value)
    where OpenXmlElementType: DXDrawCharts.PlotArea, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLayout(openXmlElement, value?.Layout);
      SetAreaChart(openXmlElement, value?.AreaChart);
      SetArea3DChart(openXmlElement, value?.Area3DChart);
      SetLineChart(openXmlElement, value?.LineChart);
      SetLine3DChart(openXmlElement, value?.Line3DChart);
      SetStockChart(openXmlElement, value?.StockChart);
      SetRadarChart(openXmlElement, value?.RadarChart);
      SetScatterChart(openXmlElement, value?.ScatterChart);
      SetPieChart(openXmlElement, value?.PieChart);
      SetPie3DChart(openXmlElement, value?.Pie3DChart);
      SetDoughnutChart(openXmlElement, value?.DoughnutChart);
      SetBarChart(openXmlElement, value?.BarChart);
      SetBar3DChart(openXmlElement, value?.Bar3DChart);
      SetOfPieChart(openXmlElement, value?.OfPieChart);
      SetSurfaceChart(openXmlElement, value?.SurfaceChart);
      SetSurface3DChart(openXmlElement, value?.Surface3DChart);
      SetBubbleChart(openXmlElement, value?.BubbleChart);
      SetValueAxis(openXmlElement, value?.ValueAxis);
      SetCategoryAxis(openXmlElement, value?.CategoryAxis);
      SetDateAxis(openXmlElement, value?.DateAxis);
      SetSeriesAxis(openXmlElement, value?.SeriesAxis);
      SetDataTable(openXmlElement, value?.DataTable);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
