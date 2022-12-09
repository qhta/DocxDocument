namespace DocumentModel.Drawings;

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
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
