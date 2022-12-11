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
  
  public Collection<ScatterChartSeries>? ScatterChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public ScatterChartExtensionList? ScatterChartExtensionList { get ; set; }
  
}
