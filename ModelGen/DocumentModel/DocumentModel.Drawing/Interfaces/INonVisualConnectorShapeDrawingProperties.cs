namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Connector Shape Drawing Properties.
/// </summary>
public interface INonVisualConnectorShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public IConnectionShapeLocks? ConnectionShapeLocks { get ; set; }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public IStartConnection? StartConnection { get ; set; }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public IEndConnection? EndConnection { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
