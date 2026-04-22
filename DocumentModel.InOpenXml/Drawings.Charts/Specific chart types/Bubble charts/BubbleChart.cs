namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a bubble chart, including color variation, series, labels, 3D bubbles, scale, negative bubble display, size representation, axis identifiers, and extension list.
/// </summary>
[XmlRoot("BubbleChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class BubbleChart : ModelElement<DXDC.BubbleChart>
{
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }
  /// <summary>
  ///   Series displayed in the bubble chart.
  /// </summary>
  public BubbleChartSeries? BubbleChartSeries { get; set; }
  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }
  /// <summary>
  ///   Indicates whether bubbles are rendered in 3D.
  /// </summary>
  public bool? Bubble3D { get; set; }
  /// <summary>
  ///   Scale factor for the size of the bubbles.
  /// </summary>
  public UInt32? BubbleScale { get; set; }
  /// <summary>
  ///   Indicates whether negative bubbles are shown.
  /// </summary>
  public bool? ShowNegativeBubbles { get; set; }
  /// <summary>
  ///   Specifies how bubble size is represented.
  /// </summary>
  public SizeRepresents? SizeRepresents { get; set; }
  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { get; set; }
  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
}