namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public interface IConnectorLockingExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IGraphic? Graphic { get ; set; }
  
}
