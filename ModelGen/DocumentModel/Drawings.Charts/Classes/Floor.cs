namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D floor formatting.
/// </summary>
public partial class Floor
{
  public Byte? Thickness { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
