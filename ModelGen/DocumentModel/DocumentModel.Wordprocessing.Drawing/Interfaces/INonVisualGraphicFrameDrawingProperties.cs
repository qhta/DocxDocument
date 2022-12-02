namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public interface INonVisualGraphicFrameDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawing.IGraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
