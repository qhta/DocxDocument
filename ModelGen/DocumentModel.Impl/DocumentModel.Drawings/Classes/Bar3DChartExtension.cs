namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public class Bar3DChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>, Bar3DChartExtension
{
  public FilteredBarSeries? FilteredBarSeries
  {
    get;
    set;
  }
  
}
