using DocumentModel.Drawings.Charts;
using PlotArea = DocumentFormat.OpenXml.Drawing.Charts.PlotArea;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Plot data and formatting.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  ///   Layout.
  /// </summary>
  public static Layout? GetLayout(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return LayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayout(PlotArea? openXmlElement, Layout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AreaChart? GetAreaChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AreaChart>();
    if (itemElement != null)
      return AreaChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAreaChart(PlotArea? openXmlElement, AreaChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AreaChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AreaChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AreaChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Area3DChart? GetArea3DChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>();
    if (itemElement != null)
      return Area3DChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArea3DChart(PlotArea? openXmlElement, Area3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Area3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineChart? GetLineChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LineChart>();
    if (itemElement != null)
      return LineChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineChart(PlotArea? openXmlElement, LineChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LineChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Line3DChart? GetLine3DChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChart>();
    if (itemElement != null)
      return Line3DChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLine3DChart(PlotArea? openXmlElement, Line3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Line3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Line3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StockChart? GetStockChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StockChart>();
    if (itemElement != null)
      return StockChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStockChart(PlotArea? openXmlElement, StockChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StockChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StockChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StockChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RadarChart? GetRadarChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>();
    if (itemElement != null)
      return RadarChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadarChart(PlotArea? openXmlElement, RadarChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadarChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ScatterChart? GetScatterChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>();
    if (itemElement != null)
      return ScatterChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScatterChart(PlotArea? openXmlElement, ScatterChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PieChart? GetPieChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChart>();
    if (itemElement != null)
      return PieChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPieChart(PlotArea? openXmlElement, PieChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PieChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Pie3DChart? GetPie3DChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>();
    if (itemElement != null)
      return Pie3DChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPie3DChart(PlotArea? openXmlElement, Pie3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Pie3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DoughnutChart? GetDoughnutChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>();
    if (itemElement != null)
      return DoughnutChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDoughnutChart(PlotArea? openXmlElement, DoughnutChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoughnutChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BarChart? GetBarChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChart>();
    if (itemElement != null)
      return BarChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBarChart(PlotArea? openXmlElement, BarChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Bar3DChart? GetBar3DChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>();
    if (itemElement != null)
      return Bar3DChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBar3DChart(PlotArea? openXmlElement, Bar3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bar3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OfPieChart? GetOfPieChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieChart>();
    if (itemElement != null)
      return OfPieChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfPieChart(PlotArea? openXmlElement, OfPieChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfPieChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SurfaceChart? GetSurfaceChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>();
    if (itemElement != null)
      return SurfaceChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSurfaceChart(PlotArea? openXmlElement, SurfaceChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SurfaceChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Surface3DChart? GetSurface3DChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>();
    if (itemElement != null)
      return Surface3DChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSurface3DChart(PlotArea? openXmlElement, Surface3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Surface3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BubbleChart? GetBubbleChart(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>();
    if (itemElement != null)
      return BubbleChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBubbleChart(PlotArea? openXmlElement, BubbleChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ValueAxis? GetValueAxis(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ValueAxis>();
    if (itemElement != null)
      return ValueAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValueAxis(PlotArea? openXmlElement, ValueAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ValueAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ValueAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CategoryAxis? GetCategoryAxis(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis>();
    if (itemElement != null)
      return CategoryAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryAxis(PlotArea? openXmlElement, CategoryAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DateAxis? GetDateAxis(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxis>();
    if (itemElement != null)
      return DateAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDateAxis(PlotArea? openXmlElement, DateAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DateAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DateAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SeriesAxis? GetSeriesAxis(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis>();
    if (itemElement != null)
      return SeriesAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesAxis(PlotArea? openXmlElement, SeriesAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DataTable? GetDataTable(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataTable>();
    if (itemElement != null)
      return DataTableConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataTable(PlotArea? openXmlElement, DataTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties? GetShapeProperties(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(PlotArea? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(PlotArea? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.PlotArea? CreateModelElement(PlotArea? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PlotArea? value)
    where OpenXmlElementType : PlotArea, new()
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