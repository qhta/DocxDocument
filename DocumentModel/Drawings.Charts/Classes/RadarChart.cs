namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Radar Charts.
/// </summary>
public class RadarChart: ModelElement
{
  /// <summary>
  ///   RadarStyle.
  /// </summary>
  public RadarStyleKind? RadarStyle { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<RadarChartSeries>? RadarChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public RadarChartExtensionList? RadarChartExtensionList { get; set; }
}