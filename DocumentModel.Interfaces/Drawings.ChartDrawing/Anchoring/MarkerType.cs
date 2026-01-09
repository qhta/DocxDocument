namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a marker type in chart drawings, including relative X and Y coordinate settings for positioning within the drawing canvas.
/// </summary>
public interface MarkerType
{
  /// <summary>
  /// Relative horizontal coordinate for positioning the marker.
  /// </summary>
  public string? XPosition { get; set; }

  /// <summary>
  /// Relative vertical coordinate for positioning the marker.
  /// </summary>
  public string? YPosition { get; set; }
}