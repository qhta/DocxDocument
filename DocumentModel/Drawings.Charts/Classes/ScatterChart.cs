namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Scatter Charts.
/// </summary>
public class ScatterChart: ModelElement
{
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }

  public Collection<ScatterChartSeries>? ScatterChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public ScatterChartExtensionList? ScatterChartExtensionList { get; set; }
}