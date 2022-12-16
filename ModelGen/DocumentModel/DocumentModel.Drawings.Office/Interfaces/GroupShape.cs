namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public interface GroupShape
{
  public DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public DocumentModel.Drawings.Office.GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawings.Office.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.Office.GroupShape? ChildGroupShape { get ; set; }
  
  public DocumentModel.Drawings.Office.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
