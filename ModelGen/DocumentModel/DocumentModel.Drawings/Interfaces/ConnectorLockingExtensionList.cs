namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public interface ConnectorLockingExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions { get ; set; }
  
}
