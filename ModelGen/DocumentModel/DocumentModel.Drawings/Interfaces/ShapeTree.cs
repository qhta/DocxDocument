namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface ShapeTree // : DocumentModel.Drawings.GroupShapeType
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Collection<Shape>? Shapes { get ; set; }
  
  public Collection<GroupShape>? GroupShapes { get ; set; }
  
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
