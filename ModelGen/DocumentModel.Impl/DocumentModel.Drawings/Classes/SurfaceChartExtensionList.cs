namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public class SurfaceChartExtensionListImpl: ModelElementImpl, SurfaceChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<SurfaceChartExtension>? SurfaceChartExtensions
  {
    get;
    set;
  }
  
}
