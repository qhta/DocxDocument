namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public class PieChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>, PieChartExtension
{
  public FilteredPieSeries? FilteredPieSeries
  {
    get;
    set;
  }
  
}
