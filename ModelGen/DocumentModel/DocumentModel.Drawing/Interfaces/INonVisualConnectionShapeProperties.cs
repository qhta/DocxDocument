namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public interface INonVisualConnectionShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public DocumentModel.Drawing.IConnectionShapeLocks? ConnectionShapeLocks { get ; set; }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public DocumentModel.Drawing.IConnectionType? StartConnection { get ; set; }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public DocumentModel.Drawing.IConnectionType? EndConnection { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
