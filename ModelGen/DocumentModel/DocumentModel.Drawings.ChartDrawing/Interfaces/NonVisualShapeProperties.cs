namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public interface NonVisualShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
