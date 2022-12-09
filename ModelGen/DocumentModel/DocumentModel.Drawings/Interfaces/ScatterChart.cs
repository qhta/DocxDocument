namespace DocumentModel.Drawings;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface ScatterChart
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<ScatterChartSeries1>? ScatterChartSerieses { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public ScatterChartExtensionList? ScatterChartExtensionList { get ; set; }
  
}
