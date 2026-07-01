namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Represents the overall style configuration for a chart, including axes, areas, data points, labels, and other chart elements.
/// </summary>
[DataContract]
[XmlRoot("ChartStyle", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class ChartStyle //: OfficeArtExtendableElement
{
  /// <summary>
  /// Unique identifier for the chart style.
  /// </summary>
  public UInt32? Id { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the chart's axis title.
  /// </summary>
  public AxisTitle? AxisTitle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the category axis.
  /// </summary>
  public CategoryAxis? CategoryAxis { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the chart area background and border.
  /// </summary>
  public ChartArea? ChartArea { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for data labels.
  /// </summary>
  public DataLabel? DataLabel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for data label callouts.
  /// </summary>
  public DataLabelCallout? DataLabelCallout { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for individual data points.
  /// </summary>
  public DataPoint? DataPoint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for 3D data points.
  /// </summary>
  public DataPoint3D? DataPoint3D { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for lines connecting data points.
  /// </summary>
  public DataPointLine? DataPointLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for data point markers.
  /// </summary>
  public DataPointMarker? DataPointMarker { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Layout properties for data point markers.
  /// </summary>
  public MarkerLayoutProperties? MarkerLayoutProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for wireframe data points.
  /// </summary>
  public DataPointWireframe? DataPointWireframe { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the data table.
  /// </summary>
  public DataTableStyle? DataTableStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for down bars in the chart.
  /// </summary>
  public DownBar? DownBar { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for drop lines in the chart.
  /// </summary>
  public DropLine? DropLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for error bars in the chart.
  /// </summary>
  public ErrorBar? ErrorBar { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the chart floor.
  /// </summary>
  public IFloor? Floor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for major gridlines.
  /// </summary>
  public GridlineMajor? GridlineMajor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for minor gridlines.
  /// </summary>
  public GridlineMinor? GridlineMinor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for high-low lines.
  /// </summary>
  public HiLoLine? HiLoLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for leader lines.
  /// </summary>
  public LeaderLine? LeaderLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the chart legend.
  /// </summary>
  public LegendStyle? LegendStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the plot area.
  /// </summary>
  public PlotArea? PlotArea { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the 3D plot area.
  /// </summary>
  public PlotArea3D? PlotArea3D { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the series axis.
  /// </summary>
  public SeriesAxis? SeriesAxis { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for series lines.
  /// </summary>
  public SeriesLine? SeriesLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the chart title.
  /// </summary>
  public TitleStyle? TitleStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for trendlines.
  /// </summary>
  public TrendlineStyle? TrendlineStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for trendline labels.
  /// </summary>
  public TrendlineLabel? TrendlineLabel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for up bars in the chart.
  /// </summary>
  public UpBar? UpBar { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the value axis.
  /// </summary>
  public ValueAxis? ValueAxis { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Style settings for the chart wall.
  /// </summary>
  public Wall? Wall { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}