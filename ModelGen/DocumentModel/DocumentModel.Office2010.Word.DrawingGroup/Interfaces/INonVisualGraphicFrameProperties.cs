namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public interface INonVisualGraphicFrameProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawing.IGraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
