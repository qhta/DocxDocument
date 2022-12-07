namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface ShapeTree
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public GroupShapeProperties1? GroupShapeProperties { get ; set; }
  
  public OfficeArtExtensionList2? OfficeArtExtensionList { get ; set; }
  
}
