namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface IShapeTree // : DocumentModel.Drawing.IGroupShapeType
{
  public IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Collection<IShape>? Shapes { get ; set; }
  
  public Collection<IGroupShape>? GroupShapes { get ; set; }
  
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
