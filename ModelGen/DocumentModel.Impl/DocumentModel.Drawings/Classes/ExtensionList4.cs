namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionList4Impl: ModelElementImpl, ExtensionList4
{
  public DocumentFormat.OpenXml.Drawing.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
