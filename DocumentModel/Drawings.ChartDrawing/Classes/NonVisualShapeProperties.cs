namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Shape Properties.
/// </summary>
public record NonVisualShapeProperties
{
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Non-Visual Shape Drawing Properties.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get; set; }
}