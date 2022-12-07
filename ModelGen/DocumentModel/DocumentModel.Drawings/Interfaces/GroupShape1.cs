namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public interface GroupShape1
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public GroupShapeProperties1? GroupShapeProperties { get ; set; }
  
  public OfficeArtExtensionList2? OfficeArtExtensionList { get ; set; }
  
}
