namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public partial class NonVisualGroupShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get; set; }
  
}
