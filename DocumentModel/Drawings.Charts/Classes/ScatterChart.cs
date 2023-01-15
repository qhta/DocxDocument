namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Scatter Charts.
/// </summary>
public class ScatterChart
{
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<ScatterChartSeries>? ScatterChartSerieses { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public ScatterChartExtensionList? ScatterChartExtensionList { get; set; }
}