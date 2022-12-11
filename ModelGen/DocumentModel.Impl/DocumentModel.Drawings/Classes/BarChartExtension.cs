namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public class BarChartExtensionImpl: ModelElementImpl, BarChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarChartExtensionImpl(): base() {}
  
  public BarChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension openXmlElement): base(openXmlElement)
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
  
  public FilteredBarSeries? FilteredBarSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
