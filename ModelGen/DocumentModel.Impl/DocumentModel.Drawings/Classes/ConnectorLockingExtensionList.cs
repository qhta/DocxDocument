namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public class ConnectorLockingExtensionListImpl: ModelElementImpl, ConnectorLockingExtensionList
{
  public DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConnectorLockingExtensionListImpl(): base() {}
  
  public ConnectorLockingExtensionListImpl(DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
