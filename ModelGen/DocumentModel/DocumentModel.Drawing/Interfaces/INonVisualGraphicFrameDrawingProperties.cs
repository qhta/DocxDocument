namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphicFrameLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface INonVisualGraphicFrameDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public IGraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
