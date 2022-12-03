namespace DocumentModel.Presentation;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface GroupShapeType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
