namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  /// Layout.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.AreaChart? GetAreaChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AreaChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.AreaChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAreaChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.AreaChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AreaChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.AreaChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AreaChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChart? GetArea3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Area3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArea3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.Area3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Area3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineChart? GetLineChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LineChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LineChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.LineChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LineChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LineChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChart? GetLine3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Line3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLine3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.Line3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Line3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Line3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StockChart? GetStockChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StockChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StockChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStockChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.StockChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StockChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.StockChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StockChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarChart? GetRadarChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.RadarChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRadarChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.RadarChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.RadarChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChart? GetScatterChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScatterChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScatterChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.ScatterChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ScatterChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChart? GetPieChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PieChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPieChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.PieChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PieChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Pie3DChart? GetPie3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Pie3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPie3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.Pie3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Pie3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DoughnutChart? GetDoughnutChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DoughnutChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDoughnutChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.DoughnutChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DoughnutChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChart? GetBarChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BarChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBarChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.BarChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BarChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Bar3DChart? GetBar3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Bar3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBar3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.Bar3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Bar3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.OfPieChart? GetOfPieChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.OfPieChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfPieChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.OfPieChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.OfPieChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChart? GetSurfaceChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SurfaceChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSurfaceChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.SurfaceChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Surface3DChart? GetSurface3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Surface3DChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSurface3DChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.Surface3DChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Surface3DChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChart? GetBubbleChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BubbleChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBubbleChart(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.BubbleChart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BubbleChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ValueAxis? GetValueAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ValueAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ValueAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetValueAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.ValueAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ValueAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ValueAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ValueAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxis? GetCategoryAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCategoryAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.CategoryAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.CategoryAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DateAxis? GetDateAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DateAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDateAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.DateAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DateAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DateAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SeriesAxis? GetSeriesAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SeriesAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeriesAxis(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.SeriesAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.SeriesAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataTable? GetDataTable(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataTable>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataTable(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.DataTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DataTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PlotArea? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PlotArea? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PlotArea, new()
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
