namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public class ChartSpaceExtensionListImpl: ModelElementImpl, ChartSpaceExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ChartSpaceExtension>? ChartSpaceExtensions
  {
    get;
    set;
  }
  
}
