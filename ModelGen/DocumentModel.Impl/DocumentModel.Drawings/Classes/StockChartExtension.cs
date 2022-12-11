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
  
  public StockChartExtensionImpl(): base() {}
  
  public StockChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
