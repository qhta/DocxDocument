namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public class GroupShape1: DocumentModel.Drawings.GroupShapeType
{
  public override GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get;
    set;
  }
  
  public override GroupShapeProperties1? GroupShapeProperties
  {
    get;
    set;
  }
  
  public OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
