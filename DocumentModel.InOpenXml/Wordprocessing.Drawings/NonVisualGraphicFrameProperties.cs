using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public interface NonVisualGraphicFrameProperties
{
  /// <summary>
  ///   Graphic Frame Locks.
  /// </summary>
  public GraphicFrameLocks? GraphicFrameLocks { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get; set; }
}