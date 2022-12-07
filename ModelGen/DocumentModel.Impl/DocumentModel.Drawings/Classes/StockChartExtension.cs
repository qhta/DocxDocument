namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public class StockChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>, StockChartExtension
{
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get;
    set;
  }
  
}
