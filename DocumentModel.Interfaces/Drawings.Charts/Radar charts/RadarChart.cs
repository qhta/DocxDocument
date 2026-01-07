namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Radar Charts.
/// </summary>
public interface RadarChart
{
  /// <summary>
  ///   RadarStyle.
  /// </summary>
  public RadarStyleKind? RadarStyle { get; set; }
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public RadarChartSeries RadarChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public AxisIds AxisIds { get; set; }
  public RadarChartExtensionList? RadarChartExtensionList { get; set; }
}