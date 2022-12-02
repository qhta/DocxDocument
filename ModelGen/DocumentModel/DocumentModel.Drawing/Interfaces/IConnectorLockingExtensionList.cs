namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public interface IConnectorLockingExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConnectorLockingExtension>? ConnectorLockingExtensions { get ; set; }
  
}
