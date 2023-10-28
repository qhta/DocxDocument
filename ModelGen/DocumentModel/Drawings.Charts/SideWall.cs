namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D side wall formatting.
/// </summary>
public partial class SideWall
{
  public Byte? Thickness { get; set; }
  
  public DMDC.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDC.PictureOptions? PictureOptions { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
