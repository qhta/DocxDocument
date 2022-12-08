namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public class ValAxExtensionListImpl: ModelElementImpl, ValAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ValAxExtension>? ValAxExtensions
  {
    get;
    set;
  }
  
}
