namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Represents the overall style configuration for a chart, including axes, areas, data points, labels, and other chart elements.
/// </summary>
public class ChartStyle //: OfficeArtExtendableElement
{
  /// <summary>
  /// Unique identifier for the chart style.
  /// </summary>
  public UInt32? Id { get; set; }
  /// <summary>
  /// Style settings for the chart's axis title.
  /// </summary>
  public AxisTitle? AxisTitle { get; set; }
  /// <summary>
  /// Style settings for the category axis.
  /// </summary>
  public CategoryAxis? CategoryAxis { get; set; }
  /// <summary>
  /// Style settings for the chart area background and border.
  /// </summary>
  public ChartArea? ChartArea { get; set; }
  /// <summary>
  /// Style settings for data labels.
  /// </summary>
  public DataLabel? DataLabel { get; set; }
  /// <summary>
  /// Style settings for data label callouts.
  /// </summary>
  public DataLabelCallout? DataLabelCallout { get; set; }
  /// <summary>
  /// Style settings for individual data points.
  /// </summary>
  public DataPoint? DataPoint { get; set; }
  /// <summary>
  /// Style settings for 3D data points.
  /// </summary>
  public DataPoint3D? DataPoint3D { get; set; }
  /// <summary>
  /// Style settings for lines connecting data points.
  /// </summary>
  public DataPointLine? DataPointLine { get; set; }
  /// <summary>
  /// Style settings for data point markers.
  /// </summary>
  public DataPointMarker? DataPointMarker { get; set; }
  /// <summary>
  /// Layout properties for data point markers.
  /// </summary>
  public MarkerLayoutProperties? MarkerLayoutProperties { get; set; }
  /// <summary>
  /// Style settings for wireframe data points.
  /// </summary>
  public DataPointWireframe? DataPointWireframe { get; set; }
  /// <summary>
  /// Style settings for the data table.
  /// </summary>
  public DataTableStyle? DataTableStyle { get; set; }
  /// <summary>
  /// Style settings for down bars in the chart.
  /// </summary>
  public DownBar? DownBar { get; set; }
  /// <summary>
  /// Style settings for drop lines in the chart.
  /// </summary>
  public DropLine? DropLine { get; set; }
  /// <summary>
  /// Style settings for error bars in the chart.
  /// </summary>
  public ErrorBar? ErrorBar { get; set; }
  /// <summary>
  /// Style settings for the chart floor.
  /// </summary>
  public Floor? Floor { get; set; }
  /// <summary>
  /// Style settings for major gridlines.
  /// </summary>
  public GridlineMajor? GridlineMajor { get; set; }
  /// <summary>
  /// Style settings for minor gridlines.
  /// </summary>
  public GridlineMinor? GridlineMinor { get; set; }
  /// <summary>
  /// Style settings for high-low lines.
  /// </summary>
  public HiLoLine? HiLoLine { get; set; }
  /// <summary>
  /// Style settings for leader lines.
  /// </summary>
  public LeaderLine? LeaderLine { get; set; }
  /// <summary>
  /// Style settings for the chart legend.
  /// </summary>
  public LegendStyle? LegendStyle { get; set; }
  /// <summary>
  /// Style settings for the plot area.
  /// </summary>
  public PlotArea? PlotArea { get; set; }
  /// <summary>
  /// Style settings for the 3D plot area.
  /// </summary>
  public PlotArea3D? PlotArea3D { get; set; }
  /// <summary>
  /// Style settings for the series axis.
  /// </summary>
  public SeriesAxis? SeriesAxis { get; set; }
  /// <summary>
  /// Style settings for series lines.
  /// </summary>
  public SeriesLine? SeriesLine { get; set; }
  /// <summary>
  /// Style settings for the chart title.
  /// </summary>
  public TitleStyle? TitleStyle { get; set; }
  /// <summary>
  /// Style settings for trendlines.
  /// </summary>
  public TrendlineStyle? TrendlineStyle { get; set; }
  /// <summary>
  /// Style settings for trendline labels.
  /// </summary>
  public TrendlineLabel? TrendlineLabel { get; set; }
  /// <summary>
  /// Style settings for up bars in the chart.
  /// </summary>
  public UpBar? UpBar { get; set; }
  /// <summary>
  /// Style settings for the value axis.
  /// </summary>
  public ValueAxis? ValueAxis { get; set; }
  /// <summary>
  /// Style settings for the chart wall.
  /// </summary>
  public Wall? Wall { get; set; }
}