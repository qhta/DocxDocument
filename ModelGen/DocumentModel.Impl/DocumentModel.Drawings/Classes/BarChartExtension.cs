namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public class BarChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>, BarChartExtension
{
  public FilteredBarSeries? FilteredBarSeries
  {
    get;
    set;
  }
  
}
