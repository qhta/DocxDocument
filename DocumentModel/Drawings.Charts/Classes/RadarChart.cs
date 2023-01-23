namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Radar Charts.
/// </summary>
public class RadarChart
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