namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D floor formatting.
/// </summary>
public partial class Floor
{
  public Byte? Thickness { get; set; }
  
  public DMDC.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDC.PictureOptions? PictureOptions { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
