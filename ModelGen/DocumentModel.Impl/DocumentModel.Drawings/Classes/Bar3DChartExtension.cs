namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public class Bar3DChartExtensionImpl: ModelElementImpl, Bar3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Bar3DChartExtensionImpl(): base() {}
  
  public Bar3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension openXmlElement): base(openXmlElement)
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
