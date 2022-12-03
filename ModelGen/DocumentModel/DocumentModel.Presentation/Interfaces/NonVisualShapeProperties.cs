namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
public interface NonVisualShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Drawing Properties for a Shape.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
