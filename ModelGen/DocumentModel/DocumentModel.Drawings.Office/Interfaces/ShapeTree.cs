namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public partial interface ShapeTree
{
  public DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }
  
  public DocumentModel.Drawings.Office.GroupShapeProperties? GroupShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Office.Shape? Shape { get; set; }
  
  public DocumentModel.Drawings.Office.GroupShape? GroupShape { get; set; }
  
  public DocumentModel.Drawings.Office.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
