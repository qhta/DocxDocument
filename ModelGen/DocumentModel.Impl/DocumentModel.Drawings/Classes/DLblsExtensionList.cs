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
  
  public Collection<DLblsExtension>? DLblsExtensions
  {
    get;
    set;
  }
  
}
