namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public interface NonVisualGraphicFrameDrawingProperties
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public GraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
