namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public class DLblsExtensionListImpl: ModelElementImpl, DLblsExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DLblsExtensionListImpl(): base() {}
  
  public DLblsExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DLblsExtension>? DLblsExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
