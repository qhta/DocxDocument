namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Group Shape.
/// </summary>
public interface NonVisualGroupShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
