namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public partial interface NonVisualConnectionShapeProperties
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ConnectionShapeLocks? ConnectionShapeLocks { get; set; }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public DocumentModel.Drawings.ConnectionType? StartConnection { get; set; }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public DocumentModel.Drawings.ConnectionType? EndConnection { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
