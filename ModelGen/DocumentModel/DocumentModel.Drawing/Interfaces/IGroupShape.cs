namespace DocumentModel.Drawing;

/// <summary>
/// Group shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public DocumentModel.Drawing.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.IVisualGroupShapeProperties? VisualGroupShapeProperties { get ; set; }
  
}
