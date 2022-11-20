namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphicFrameLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class NonVisualGraphicFrameProperties: INonVisualGraphicFrameProperties
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public IGraphicFrameLocks? GraphicFrameLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
