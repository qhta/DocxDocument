namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes the ending anchor point for a shape in chart drawings, including horizontal and vertical position settings.
/// </summary>
public interface ToAnchor
{
  /// <summary>
  /// Horizontal position value for the anchor point within the drawing canvas.
  /// </summary>
  public string? XPosition { get; set; }

  /// <summary>
  /// Vertical position value for the anchor point within the drawing canvas.
  /// </summary>
  public string? YPosition { get; set; }
}