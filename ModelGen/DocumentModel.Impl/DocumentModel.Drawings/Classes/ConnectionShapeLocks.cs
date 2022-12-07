namespace DocumentModel.Drawings;

/// <summary>
/// Connection Shape Locks.
/// </summary>
public class ConnectionShapeLocksImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>, ConnectionShapeLocks
{
  /// <summary>
  /// ConnectorLockingExtensionList.
  /// </summary>
  public ConnectorLockingExtensionList? ConnectorLockingExtensionList
  {
    get;
    set;
  }
  
}
