namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface ScatterChart
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.ScatterStyleKind? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>? ScatterChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public DocumentModel.Drawings.Charts.ScatterChartExtensionList? ScatterChartExtensionList { get ; set; }
  
}
