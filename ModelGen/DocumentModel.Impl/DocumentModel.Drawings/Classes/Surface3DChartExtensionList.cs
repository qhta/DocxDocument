namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public class Surface3DChartExtensionListImpl: ModelElementImpl, Surface3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Surface3DChartExtension>? Surface3DChartExtensions
  {
    get;
    set;
  }
  
}
