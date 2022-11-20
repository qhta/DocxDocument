namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
public interface IConnectorLockingExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
