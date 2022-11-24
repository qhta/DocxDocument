namespace DocumentModel.Drawing.LockedCanvas;

/// <summary>
/// Locked Canvas Container.
/// </summary>
public interface ILockedCanvas // : DocumentModel.ITypedOpenXmlCompositeElement
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
