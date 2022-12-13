namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public interface NonVisualShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
