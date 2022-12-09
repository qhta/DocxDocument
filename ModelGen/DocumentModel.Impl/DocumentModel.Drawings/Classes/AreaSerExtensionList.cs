namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public class AreaSerExtensionListImpl: ModelElementImpl, AreaSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<AreaSerExtension>? AreaSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
