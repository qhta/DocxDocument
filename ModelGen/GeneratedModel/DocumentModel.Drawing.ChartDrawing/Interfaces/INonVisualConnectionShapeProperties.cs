namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IStartConnection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEndConnection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IConnectionShapeLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface INonVisualConnectionShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
