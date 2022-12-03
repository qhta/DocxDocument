namespace DocumentModel.Drawings;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public interface Pie3DChart // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries>? PieChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public Pie3DChartExtensionList? Pie3DChartExtensionList { get ; set; }
  
}
