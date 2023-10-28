namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree
{
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }
  
  public DMDO.GroupShapeProperties? GroupShapeProperties { get; set; }
  
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
