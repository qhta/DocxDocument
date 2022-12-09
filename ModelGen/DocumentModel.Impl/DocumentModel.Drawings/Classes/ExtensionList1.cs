namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionList1Impl: ModelElementImpl, ExtensionList1
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
