namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Non-Visual Shape Properties.
/// </summary>
public class NonVisualShapeProperties: ModelElement
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