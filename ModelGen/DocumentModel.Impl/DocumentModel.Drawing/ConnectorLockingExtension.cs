namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
public class ConnectorLockingExtension: IConnectorLockingExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
