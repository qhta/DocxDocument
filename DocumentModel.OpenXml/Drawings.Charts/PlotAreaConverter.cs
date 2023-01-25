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
    return DMXDrawsCharts.LayoutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Layout>());
  }
  
  private static bool CmpLayout(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Layout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Layout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.AreaChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.AreaChart>());
  }
  
  private static bool CmpAreaChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.AreaChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.AreaChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.AreaChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.Area3DChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Area3DChart>());
  }
  
  private static bool CmpArea3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Area3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Area3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Area3DChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.LineChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.LineChart>());
  }
  
  private static bool CmpLineChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.LineChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LineChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.LineChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.Line3DChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Line3DChart>());
  }
  
  private static bool CmpLine3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Line3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Line3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Line3DChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.StockChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StockChart>());
  }
  
  private static bool CmpStockChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.StockChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StockChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StockChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.RadarChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.RadarChart>());
  }
  
  private static bool CmpRadarChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.RadarChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.RadarChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.RadarChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.ScatterChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ScatterChart>());
  }
  
  private static bool CmpScatterChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ScatterChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScatterChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ScatterChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.PieChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PieChart>());
  }
  
  private static bool CmpPieChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.PieChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PieChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PieChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.Pie3DChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Pie3DChart>());
  }
  
  private static bool CmpPie3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Pie3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Pie3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Pie3DChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.DoughnutChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DoughnutChart>());
  }
  
  private static bool CmpDoughnutChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.DoughnutChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DoughnutChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DoughnutChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.BarChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BarChart>());
  }
  
  private static bool CmpBarChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.BarChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BarChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.BarChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.Bar3DChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Bar3DChart>());
  }
  
  private static bool CmpBar3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Bar3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Bar3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Bar3DChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.OfPieChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.OfPieChart>());
  }
  
  private static bool CmpOfPieChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.OfPieChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.OfPieChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.OfPieChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.SurfaceChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceChart>());
  }
  
  private static bool CmpSurfaceChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.SurfaceChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SurfaceChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SurfaceChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.Surface3DChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Surface3DChart>());
  }
  
  private static bool CmpSurface3DChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.Surface3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Surface3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Surface3DChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.BubbleChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BubbleChart>());
  }
  
  private static bool CmpBubbleChart(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.BubbleChart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BubbleChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.BubbleChart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.ValueAxisConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ValueAxis>());
  }
  
  private static bool CmpValueAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ValueAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ValueAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ValueAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.CategoryAxisConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxis>());
  }
  
  private static bool CmpCategoryAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.CategoryAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.CategoryAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.DateAxisConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DateAxis>());
  }
  
  private static bool CmpDateAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.DateAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DateAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DateAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.SeriesAxisConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SeriesAxis>());
  }
  
  private static bool CmpSeriesAxis(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.SeriesAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SeriesAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SeriesAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.DataTableConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataTable>());
  }
  
  private static bool CmpDataTable(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.DataTable? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataTable>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.PlotArea openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawCharts.PlotArea? openXmlElement, DMDrawsCharts.PlotArea? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      if (!CmpAreaChart(openXmlElement, value.AreaChart, diffs, objName))
        ok = false;
      if (!CmpArea3DChart(openXmlElement, value.Area3DChart, diffs, objName))
        ok = false;
      if (!CmpLineChart(openXmlElement, value.LineChart, diffs, objName))
        ok = false;
      if (!CmpLine3DChart(openXmlElement, value.Line3DChart, diffs, objName))
        ok = false;
      if (!CmpStockChart(openXmlElement, value.StockChart, diffs, objName))
        ok = false;
      if (!CmpRadarChart(openXmlElement, value.RadarChart, diffs, objName))
        ok = false;
      if (!CmpScatterChart(openXmlElement, value.ScatterChart, diffs, objName))
        ok = false;
      if (!CmpPieChart(openXmlElement, value.PieChart, diffs, objName))
        ok = false;
      if (!CmpPie3DChart(openXmlElement, value.Pie3DChart, diffs, objName))
        ok = false;
      if (!CmpDoughnutChart(openXmlElement, value.DoughnutChart, diffs, objName))
        ok = false;
      if (!CmpBarChart(openXmlElement, value.BarChart, diffs, objName))
        ok = false;
      if (!CmpBar3DChart(openXmlElement, value.Bar3DChart, diffs, objName))
        ok = false;
      if (!CmpOfPieChart(openXmlElement, value.OfPieChart, diffs, objName))
        ok = false;
      if (!CmpSurfaceChart(openXmlElement, value.SurfaceChart, diffs, objName))
        ok = false;
      if (!CmpSurface3DChart(openXmlElement, value.Surface3DChart, diffs, objName))
        ok = false;
      if (!CmpBubbleChart(openXmlElement, value.BubbleChart, diffs, objName))
        ok = false;
      if (!CmpValueAxis(openXmlElement, value.ValueAxis, diffs, objName))
        ok = false;
      if (!CmpCategoryAxis(openXmlElement, value.CategoryAxis, diffs, objName))
        ok = false;
      if (!CmpDateAxis(openXmlElement, value.DateAxis, diffs, objName))
        ok = false;
      if (!CmpSeriesAxis(openXmlElement, value.SeriesAxis, diffs, objName))
        ok = false;
      if (!CmpDataTable(openXmlElement, value.DataTable, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
