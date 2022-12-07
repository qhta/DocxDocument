namespace DocumentModel.Drawings;

/// <summary>
/// Doughnut Charts.
/// </summary>
public class DoughnutChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart>, DoughnutChart
{
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
