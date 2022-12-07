namespace DocumentModel.Drawings;

/// <summary>
/// Pie Charts.
/// </summary>
public class PieChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.PieChart>, PieChart
{
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public PieChartExtensionList? PieChartExtensionList
  {
    get;
    set;
  }
  
}
