namespace DocumentModel.Drawings;

/// <summary>
/// Doughnut Charts.
/// </summary>
public interface DoughnutChart // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries>? PieChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public Byte? HoleSize { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
