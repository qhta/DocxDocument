namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public interface GroupShape
{
  public DocumentModel.Drawings.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public DocumentModel.Drawings.GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawings.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.GroupShape? ChildGroupShape { get ; set; }
  
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
