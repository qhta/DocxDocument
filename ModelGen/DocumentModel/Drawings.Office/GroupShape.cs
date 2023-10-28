namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public partial class GroupShape
{
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }
  
  public DMDO.GroupShapeProperties? GroupShapeProperties { get; set; }
  
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
