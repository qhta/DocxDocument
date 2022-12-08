namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public class StockChartExtensionImpl: ModelElementImpl, StockChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get;
    set;
  }
  
}
