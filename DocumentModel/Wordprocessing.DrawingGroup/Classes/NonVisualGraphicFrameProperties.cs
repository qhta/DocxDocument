using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public class NonVisualGraphicFrameProperties: ModelElement
{
  /// <summary>
  ///   Graphic Frame Locks.
  /// </summary>
  public GraphicFrameLocks? GraphicFrameLocks { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
}