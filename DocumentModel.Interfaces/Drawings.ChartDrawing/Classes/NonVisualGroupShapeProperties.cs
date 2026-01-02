namespace DocumentModel.Drawings.ChartDrawing;

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