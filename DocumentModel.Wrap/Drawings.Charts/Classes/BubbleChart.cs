namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Bubble Charts.
/// </summary>
public class BubbleChart: ModelElement
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }

  public Collection<BubbleChartSeries>? BubbleChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public bool? Bubble3D { get; set; }

  public UInt32? BubbleScale { get; set; }

  public bool? ShowNegativeBubbles { get; set; }

  public SizeRepresentsKind? SizeRepresents { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
}