namespace DocumentModel.Drawing.ChartDrawing;

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
