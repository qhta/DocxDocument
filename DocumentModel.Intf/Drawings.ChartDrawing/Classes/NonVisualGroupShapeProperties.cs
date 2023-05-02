namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Non-Visual Group Shape Properties.
/// </summary>
public class NonVisualGroupShapeProperties: ModelElement
{
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get; set; }
}