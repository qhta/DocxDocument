namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public interface NonVisualShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
