namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a graphic frame in chart drawings, including locking options that restrict editing or manipulation of the frame.
/// </summary>
public interface NonVisualGraphicFrameDrawingProperties : ExtendableElement
{
  /// <summary>
  /// Specifies locking options for the graphic frame to control editing and manipulation.
  /// </summary>
  public GraphicFrameLocks? GraphicFrameLocks { get; set; }
}