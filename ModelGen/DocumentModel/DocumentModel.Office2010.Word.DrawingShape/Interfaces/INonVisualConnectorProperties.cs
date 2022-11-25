namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the NonVisualConnectorProperties Class.
/// </summary>
public interface INonVisualConnectorProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
