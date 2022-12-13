namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public class AreaChartExtensionImpl: ModelElementImpl, AreaChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AreaChartExtensionImpl(): base() {}
  
  public AreaChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings13.Charts.FilteredAreaSeries? FilteredAreaSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
