namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  /// Layout.
  /// </summary>
  private static DMDC.Layout? GetLayout(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Layout>();
    if (element != null)
      return DMXDC.LayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDC.PlotArea openXmlElement, DMDC.Layout? value, DiffList? diffs, string? objName)
  {
    return DMXDC.LayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Layout>(), value, diffs, objName);
  }
  
  private static void SetLayout(DXDC.PlotArea openXmlElement, DMDC.Layout? value)
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
  
  private static DMDC.AreaChart? GetAreaChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.AreaChart>();
    if (element != null)
      return DMXDC.AreaChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAreaChart(DXDC.PlotArea openXmlElement, DMDC.AreaChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.AreaChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.AreaChart>(), value, diffs, objName);
  }
  
  private static void SetAreaChart(DXDC.PlotArea openXmlElement, DMDC.AreaChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.AreaChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.AreaChartConverter.CreateOpenXmlElement<DXDC.AreaChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Area3DChart? GetArea3DChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Area3DChart>();
    if (element != null)
      return DMXDC.Area3DChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArea3DChart(DXDC.PlotArea openXmlElement, DMDC.Area3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Area3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Area3DChart>(), value, diffs, objName);
  }
  
  private static void SetArea3DChart(DXDC.PlotArea openXmlElement, DMDC.Area3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Area3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Area3DChartConverter.CreateOpenXmlElement<DXDC.Area3DChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.LineChart? GetLineChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.LineChart>();
    if (element != null)
      return DMXDC.LineChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineChart(DXDC.PlotArea openXmlElement, DMDC.LineChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.LineChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.LineChart>(), value, diffs, objName);
  }
  
  private static void SetLineChart(DXDC.PlotArea openXmlElement, DMDC.LineChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LineChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LineChartConverter.CreateOpenXmlElement<DXDC.LineChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Line3DChart? GetLine3DChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Line3DChart>();
    if (element != null)
      return DMXDC.Line3DChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine3DChart(DXDC.PlotArea openXmlElement, DMDC.Line3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Line3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Line3DChart>(), value, diffs, objName);
  }
  
  private static void SetLine3DChart(DXDC.PlotArea openXmlElement, DMDC.Line3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Line3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Line3DChartConverter.CreateOpenXmlElement<DXDC.Line3DChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.StockChart? GetStockChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StockChart>();
    if (element != null)
      return DMXDC.StockChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStockChart(DXDC.PlotArea openXmlElement, DMDC.StockChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.StockChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StockChart>(), value, diffs, objName);
  }
  
  private static void SetStockChart(DXDC.PlotArea openXmlElement, DMDC.StockChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StockChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StockChartConverter.CreateOpenXmlElement<DXDC.StockChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.RadarChart? GetRadarChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.RadarChart>();
    if (element != null)
      return DMXDC.RadarChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadarChart(DXDC.PlotArea openXmlElement, DMDC.RadarChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.RadarChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.RadarChart>(), value, diffs, objName);
  }
  
  private static void SetRadarChart(DXDC.PlotArea openXmlElement, DMDC.RadarChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.RadarChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.RadarChartConverter.CreateOpenXmlElement<DXDC.RadarChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ScatterChart? GetScatterChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ScatterChart>();
    if (element != null)
      return DMXDC.ScatterChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScatterChart(DXDC.PlotArea openXmlElement, DMDC.ScatterChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ScatterChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ScatterChart>(), value, diffs, objName);
  }
  
  private static void SetScatterChart(DXDC.PlotArea openXmlElement, DMDC.ScatterChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ScatterChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ScatterChartConverter.CreateOpenXmlElement<DXDC.ScatterChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.PieChart? GetPieChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PieChart>();
    if (element != null)
      return DMXDC.PieChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPieChart(DXDC.PlotArea openXmlElement, DMDC.PieChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PieChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PieChart>(), value, diffs, objName);
  }
  
  private static void SetPieChart(DXDC.PlotArea openXmlElement, DMDC.PieChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PieChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PieChartConverter.CreateOpenXmlElement<DXDC.PieChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Pie3DChart? GetPie3DChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Pie3DChart>();
    if (element != null)
      return DMXDC.Pie3DChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPie3DChart(DXDC.PlotArea openXmlElement, DMDC.Pie3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Pie3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Pie3DChart>(), value, diffs, objName);
  }
  
  private static void SetPie3DChart(DXDC.PlotArea openXmlElement, DMDC.Pie3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Pie3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Pie3DChartConverter.CreateOpenXmlElement<DXDC.Pie3DChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DoughnutChart? GetDoughnutChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DoughnutChart>();
    if (element != null)
      return DMXDC.DoughnutChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDoughnutChart(DXDC.PlotArea openXmlElement, DMDC.DoughnutChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DoughnutChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DoughnutChart>(), value, diffs, objName);
  }
  
  private static void SetDoughnutChart(DXDC.PlotArea openXmlElement, DMDC.DoughnutChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DoughnutChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DoughnutChartConverter.CreateOpenXmlElement<DXDC.DoughnutChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.BarChart? GetBarChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BarChart>();
    if (element != null)
      return DMXDC.BarChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarChart(DXDC.PlotArea openXmlElement, DMDC.BarChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BarChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BarChart>(), value, diffs, objName);
  }
  
  private static void SetBarChart(DXDC.PlotArea openXmlElement, DMDC.BarChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BarChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BarChartConverter.CreateOpenXmlElement<DXDC.BarChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Bar3DChart? GetBar3DChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Bar3DChart>();
    if (element != null)
      return DMXDC.Bar3DChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar3DChart(DXDC.PlotArea openXmlElement, DMDC.Bar3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Bar3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Bar3DChart>(), value, diffs, objName);
  }
  
  private static void SetBar3DChart(DXDC.PlotArea openXmlElement, DMDC.Bar3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Bar3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Bar3DChartConverter.CreateOpenXmlElement<DXDC.Bar3DChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.OfPieChart? GetOfPieChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.OfPieChart>();
    if (element != null)
      return DMXDC.OfPieChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfPieChart(DXDC.PlotArea openXmlElement, DMDC.OfPieChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.OfPieChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.OfPieChart>(), value, diffs, objName);
  }
  
  private static void SetOfPieChart(DXDC.PlotArea openXmlElement, DMDC.OfPieChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.OfPieChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.OfPieChartConverter.CreateOpenXmlElement<DXDC.OfPieChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.SurfaceChart? GetSurfaceChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SurfaceChart>();
    if (element != null)
      return DMXDC.SurfaceChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurfaceChart(DXDC.PlotArea openXmlElement, DMDC.SurfaceChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SurfaceChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SurfaceChart>(), value, diffs, objName);
  }
  
  private static void SetSurfaceChart(DXDC.PlotArea openXmlElement, DMDC.SurfaceChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SurfaceChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SurfaceChartConverter.CreateOpenXmlElement<DXDC.SurfaceChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Surface3DChart? GetSurface3DChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Surface3DChart>();
    if (element != null)
      return DMXDC.Surface3DChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurface3DChart(DXDC.PlotArea openXmlElement, DMDC.Surface3DChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Surface3DChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Surface3DChart>(), value, diffs, objName);
  }
  
  private static void SetSurface3DChart(DXDC.PlotArea openXmlElement, DMDC.Surface3DChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Surface3DChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Surface3DChartConverter.CreateOpenXmlElement<DXDC.Surface3DChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.BubbleChart? GetBubbleChart(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BubbleChart>();
    if (element != null)
      return DMXDC.BubbleChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleChart(DXDC.PlotArea openXmlElement, DMDC.BubbleChart? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BubbleChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BubbleChart>(), value, diffs, objName);
  }
  
  private static void SetBubbleChart(DXDC.PlotArea openXmlElement, DMDC.BubbleChart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BubbleChart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BubbleChartConverter.CreateOpenXmlElement<DXDC.BubbleChart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ValueAxis? GetValueAxis(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ValueAxis>();
    if (element != null)
      return DMXDC.ValueAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueAxis(DXDC.PlotArea openXmlElement, DMDC.ValueAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ValueAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ValueAxis>(), value, diffs, objName);
  }
  
  private static void SetValueAxis(DXDC.PlotArea openXmlElement, DMDC.ValueAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ValueAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ValueAxisConverter.CreateOpenXmlElement<DXDC.ValueAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.CategoryAxis? GetCategoryAxis(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.CategoryAxis>();
    if (element != null)
      return DMXDC.CategoryAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxis(DXDC.PlotArea openXmlElement, DMDC.CategoryAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDC.CategoryAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.CategoryAxis>(), value, diffs, objName);
  }
  
  private static void SetCategoryAxis(DXDC.PlotArea openXmlElement, DMDC.CategoryAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.CategoryAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CategoryAxisConverter.CreateOpenXmlElement<DXDC.CategoryAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DateAxis? GetDateAxis(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DateAxis>();
    if (element != null)
      return DMXDC.DateAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDateAxis(DXDC.PlotArea openXmlElement, DMDC.DateAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DateAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DateAxis>(), value, diffs, objName);
  }
  
  private static void SetDateAxis(DXDC.PlotArea openXmlElement, DMDC.DateAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DateAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DateAxisConverter.CreateOpenXmlElement<DXDC.DateAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.SeriesAxis? GetSeriesAxis(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SeriesAxis>();
    if (element != null)
      return DMXDC.SeriesAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesAxis(DXDC.PlotArea openXmlElement, DMDC.SeriesAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SeriesAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SeriesAxis>(), value, diffs, objName);
  }
  
  private static void SetSeriesAxis(DXDC.PlotArea openXmlElement, DMDC.SeriesAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SeriesAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SeriesAxisConverter.CreateOpenXmlElement<DXDC.SeriesAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DataTable? GetDataTable(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataTable>();
    if (element != null)
      return DMXDC.DataTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataTable(DXDC.PlotArea openXmlElement, DMDC.DataTable? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataTable>(), value, diffs, objName);
  }
  
  private static void SetDataTable(DXDC.PlotArea openXmlElement, DMDC.DataTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataTableConverter.CreateOpenXmlElement<DXDC.DataTable>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ShapeProperties? GetShapeProperties(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDC.PlotArea openXmlElement, DMDC.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXDC.PlotArea openXmlElement, DMDC.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapePropertiesConverter.CreateOpenXmlElement<DXDC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.PlotArea openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.PlotArea openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PlotArea? CreateModelElement(DXDC.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PlotArea();
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
  
  public static bool CompareModelElement(DXDC.PlotArea? openXmlElement, DMDC.PlotArea? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PlotArea value)
    where OpenXmlElementType: DXDC.PlotArea, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PlotArea openXmlElement, DMDC.PlotArea value)
  {
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
  }
}
