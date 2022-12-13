namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public class Surface3DChartExtensionImpl: ModelElementImpl, Surface3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Surface3DChartExtensionImpl(): base() {}
  
  public Surface3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings13.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
