namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public interface INonVisualGraphicFrameProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
