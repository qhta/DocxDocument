namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public interface INonVisualConnectionShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public IConnectionShapeLocks? ConnectionShapeLocks { get ; set; }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public IConnectionType? StartConnection { get ; set; }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public IConnectionType? EndConnection { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
