namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionList1Impl: ModelElementImpl, ExtensionList1
{
  public DocumentFormat.OpenXml.Drawing.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension>? Extensions
  {
    get;
    set;
  }
  
}
