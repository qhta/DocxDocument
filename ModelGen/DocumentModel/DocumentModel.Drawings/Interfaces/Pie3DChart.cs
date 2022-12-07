namespace DocumentModel.Drawings;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public interface Pie3DChart
{
  public DataLabels1? DataLabels { get ; set; }
  
  public Pie3DChartExtensionList? Pie3DChartExtensionList { get ; set; }
  
}
