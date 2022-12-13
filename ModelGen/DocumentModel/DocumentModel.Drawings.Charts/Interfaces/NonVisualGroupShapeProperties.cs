namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public interface NonVisualGroupShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }
  
}
