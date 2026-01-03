namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ConnectorLockingExtensionList interface.
/// </summary>
public interface ConnectorLockingExtensionList: IModelElement
{
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions { get; set; }
}