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
  
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions
  {
    get;
    set;
  }
  
}
