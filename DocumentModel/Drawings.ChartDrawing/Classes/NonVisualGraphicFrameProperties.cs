namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Graphic Frame Properties.
/// </summary>
public class NonVisualGraphicFrameProperties
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