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
  
  public ChartSpaceExtensionListImpl(): base() {}
  
  public ChartSpaceExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<ChartSpaceExtension>? ChartSpaceExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
