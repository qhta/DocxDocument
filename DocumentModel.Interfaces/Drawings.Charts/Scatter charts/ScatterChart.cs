namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Scatter Charts.
/// </summary>
public interface ScatterChart
{
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle { get; set; }
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public ScatterChartSeries ScatterChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public AxisIds AxisIds { get; set; }
  public ScatterChartExtensionList? ScatterChartExtensionList { get; set; }
}