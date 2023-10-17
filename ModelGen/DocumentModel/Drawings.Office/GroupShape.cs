namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public partial class GroupShape
{
  public DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }
  
  public DocumentModel.Drawings.Office.GroupShapeProperties? GroupShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Office.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
