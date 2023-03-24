namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Non-Visual Graphic Frame Properties.
/// </summary>
public class NonVisualGraphicFrameProperties: ModelElement
{
  /// <summary>
  ///   Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get; set; }
}