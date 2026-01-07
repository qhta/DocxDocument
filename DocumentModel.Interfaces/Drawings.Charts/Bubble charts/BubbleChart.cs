namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Bubble Charts.
/// </summary>
public interface BubbleChart
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public BubbleChartSeries BubbleChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public bool? Bubble3D { get; set; }
  public UInt32? BubbleScale { get; set; }
  public bool? ShowNegativeBubbles { get; set; }
  public SizeRepresentsKind? SizeRepresents { get; set; }
  public AxisIds? AxisIds { get; set; }
  public BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
}