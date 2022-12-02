namespace DocumentModel.Presentation;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface IGroupShapeType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
