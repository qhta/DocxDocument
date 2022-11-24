namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
