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
    get;
    set;
  }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get;
    set;
  }
  
}
