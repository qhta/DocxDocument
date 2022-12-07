namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public class LineChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>, LineChartExtension
{
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get;
    set;
  }
  
}
