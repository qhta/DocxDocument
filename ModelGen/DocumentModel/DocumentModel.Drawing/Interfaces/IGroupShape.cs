namespace DocumentModel.Drawing;

/// <summary>
/// Group shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Visual Group Shape Properties.
  /// </summary>
  public IVisualGroupShapeProperties? VisualGroupShapeProperties { get ; set; }
  
}
