namespace DocumentModel.Drawings;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public class Pie3DChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart>, Pie3DChart
{
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public Pie3DChartExtensionList? Pie3DChartExtensionList
  {
    get;
    set;
  }
  
}
