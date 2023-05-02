namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public class NonVisualGraphicFrameDrawingProperties: ModelElement
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