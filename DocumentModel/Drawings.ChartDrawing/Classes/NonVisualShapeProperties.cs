namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Non-Visual IShape Properties.
/// </summary>
public class NonVisualShapeProperties: ModelElement
{
  /// <summary>
  ///   IChart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Non-Visual IShape Drawing Properties.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get; set; }
}
