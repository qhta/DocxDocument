namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public class StockChartExtensionListImpl: ModelElementImpl, StockChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<StockChartExtension>? StockChartExtensions
  {
    get;
    set;
  }
  
}
