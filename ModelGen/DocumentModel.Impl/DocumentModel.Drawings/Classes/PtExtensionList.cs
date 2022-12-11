namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public class PtExtensionListImpl: ModelElementImpl, PtExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PtExtensionListImpl(): base() {}
  
  public PtExtensionListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<PtExtension>? PtExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
