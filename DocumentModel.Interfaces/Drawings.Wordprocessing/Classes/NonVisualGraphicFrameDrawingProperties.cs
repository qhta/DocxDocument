namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public interface NonVisualGraphicFrameDrawingProperties:
{
  /// <summary>
  ///   Graphic Frame Locks.
  /// </summary>
  public GraphicFrameLocks? GraphicFrameLocks { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}