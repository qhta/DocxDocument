using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingGroup;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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