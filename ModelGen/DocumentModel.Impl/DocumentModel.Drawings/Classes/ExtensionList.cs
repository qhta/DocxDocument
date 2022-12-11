namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionListImpl: ModelElementImpl, ExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionListImpl(): base() {}
  
  public ExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
