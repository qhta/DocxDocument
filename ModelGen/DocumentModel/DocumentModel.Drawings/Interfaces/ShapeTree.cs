namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface ShapeTree
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public GroupShapeProperties1? GroupShapeProperties { get ; set; }
  
  public Collection<Shape1>? Shapes { get ; set; }
  
  public Collection<GroupShape2>? GroupShapes { get ; set; }
  
  public OfficeArtExtensionList1? OfficeArtExtensionList { get ; set; }
  
}
