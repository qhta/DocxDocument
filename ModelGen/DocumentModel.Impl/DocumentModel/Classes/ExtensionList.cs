namespace DocumentModel;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionListImpl: ModelElementImpl, ExtensionList
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionListImpl(): base() {}
  
  public ExtensionListImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
