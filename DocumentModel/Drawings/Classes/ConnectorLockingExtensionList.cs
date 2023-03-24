namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ConnectorLockingExtensionList Class.
/// </summary>
public class ConnectorLockingExtensionList: ModelElement
{
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions { get; set; }
}