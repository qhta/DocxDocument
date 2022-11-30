namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
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
