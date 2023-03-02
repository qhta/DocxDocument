namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Bubble Charts.
/// </summary>
public record BubbleChart
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<BubbleChartSeries>? BubbleChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Boolean? Bubble3D { get; set; }

  public UInt32? BubbleScale { get; set; }

  public Boolean? ShowNegativeBubbles { get; set; }

  public SizeRepresentsKind? SizeRepresents { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
}