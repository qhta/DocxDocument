namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the NonVisualConnectorProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IStartConnection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEndConnection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IConnectionShapeLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class NonVisualConnectorProperties: INonVisualConnectorProperties
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public IConnectionShapeLocks? ConnectionShapeLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public IStartConnection? StartConnection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public IEndConnection? EndConnection
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
