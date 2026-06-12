namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a 3D line chart, including grouping, color variation, series, labels, drop lines, gap depth, axis identifiers, and extension list.
/// </summary>
[XmlRoot("Line3DChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Line3DChart : ModelElement<DXDC.Line3DChart>
{
  /// <summary>
  ///   Specifies the grouping type for the 3D line chart.
  /// </summary>
  public Grouping? Grouping { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Series displayed in the 3D line chart.
  /// </summary>
  public LineChartSeriesList? LineChartSeries { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Drop lines configuration for the chart.
  /// </summary>
  public DropLines? DropLines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Gap depth value for the 3D line chart.
  /// </summary>
  public UInt16? GapDepth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public Line3DChartExtensionList? Line3DChartExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}