namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface ShapeTree
{
  public DocumentModel.Drawings.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public DocumentModel.Drawings.GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawings.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.GroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
