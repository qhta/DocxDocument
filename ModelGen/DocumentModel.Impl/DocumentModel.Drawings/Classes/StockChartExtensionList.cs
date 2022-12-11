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
  
  public StockChartExtensionListImpl(): base() {}
  
  public StockChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<StockChartExtension>? StockChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
