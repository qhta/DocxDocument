namespace DocumentModel.Drawings;

/// <summary>
/// Plot data and formatting.
/// </summary>
public interface PlotArea2
{
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout1? Layout { get ; set; }
  
  public Collection<AreaChart>? AreaCharts { get ; set; }
  
  public Collection<Area3DChart>? Area3DCharts { get ; set; }
  
  public Collection<LineChart>? LineCharts { get ; set; }
  
  public Collection<Line3DChart>? Line3DCharts { get ; set; }
  
  public Collection<StockChart>? StockCharts { get ; set; }
  
  public Collection<RadarChart>? RadarCharts { get ; set; }
  
  public Collection<ScatterChart>? ScatterCharts { get ; set; }
  
  public Collection<PieChart>? PieCharts { get ; set; }
  
  public Collection<Pie3DChart>? Pie3DCharts { get ; set; }
  
  public Collection<DoughnutChart>? DoughnutCharts { get ; set; }
  
  public Collection<BarChart>? BarCharts { get ; set; }
  
  public Collection<Bar3DChart>? Bar3DCharts { get ; set; }
  
  public Collection<OfPieChart>? OfPieCharts { get ; set; }
  
  public Collection<SurfaceChart>? SurfaceCharts { get ; set; }
  
  public Collection<Surface3DChart>? Surface3DCharts { get ; set; }
  
  public Collection<BubbleChart>? BubbleCharts { get ; set; }
  
  public Collection<ValueAxis1>? ValueAxises { get ; set; }
  
  public Collection<CategoryAxis1>? CategoryAxises { get ; set; }
  
  public Collection<DateAxis>? DateAxises { get ; set; }
  
  public Collection<SeriesAxis2>? SeriesAxises { get ; set; }
  
  public DataTable? DataTable { get ; set; }
  
  public ShapeProperties5? ShapeProperties { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
