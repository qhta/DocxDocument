namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public interface GroupShape2
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public GroupShapeProperties2? GroupShapeProperties { get ; set; }
  
  public Collection<Shape2>? Shapes { get ; set; }
  
  public Collection<GroupShape2>? GroupShapes { get ; set; }
  
  public OfficeArtExtensionList5? OfficeArtExtensionList { get ; set; }
  
}
