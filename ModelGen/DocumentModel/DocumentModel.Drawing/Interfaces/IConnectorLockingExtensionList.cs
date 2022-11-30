namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public interface IConnectorLockingExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IConnectorLockingExtension>? ConnectorLockingExtensions { get ; set; }
  
}
