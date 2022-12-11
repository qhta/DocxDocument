namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public interface NonVisualGroupShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }
  
}
