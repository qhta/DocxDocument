namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public class DLblExtensionListImpl: ModelElementImpl, DLblExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DLblExtension>? DLblExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
