namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ConnectorLockingExtensionList Class.
/// </summary>
public record ConnectorLockingExtensionList
{
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions { get; set; }
}