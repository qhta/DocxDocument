namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public interface INonVisualGraphicFrameDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public IGraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
