namespace DocumentModel.Drawings;

/// <summary>
/// Pie Charts.
/// </summary>
public interface PieChart // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries>? PieChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public PieChartExtensionList? PieChartExtensionList { get ; set; }
  
}
