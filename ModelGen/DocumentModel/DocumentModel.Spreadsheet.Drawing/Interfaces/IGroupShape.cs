namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Collection<IShape>? Shapes { get ; set; }
  
  public Collection<IGroupShape>? GroupShapes { get ; set; }
  
  public Collection<IGraphicFrame>? GraphicFrames { get ; set; }
  
  public Collection<IConnectionShape>? ConnectionShapes { get ; set; }
  
  public Collection<IPicture>? Pictures { get ; set; }
  
}
