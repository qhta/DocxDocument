namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D side wall formatting.
/// </summary>
public partial class SideWall
{
  public Byte? Thickness { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
