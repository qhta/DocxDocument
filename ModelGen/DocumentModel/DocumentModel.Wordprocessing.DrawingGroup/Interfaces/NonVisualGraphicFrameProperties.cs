namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public partial interface NonVisualGraphicFrameProperties
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawings.GraphicFrameLocks? GraphicFrameLocks { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
