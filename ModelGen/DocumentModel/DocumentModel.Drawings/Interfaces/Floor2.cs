namespace DocumentModel.Drawings;

/// <summary>
/// 3D floor formatting.
/// </summary>
public interface Floor2
{
  public Byte? Thickness { get ; set; }
  
  public ShapeProperties5? ShapeProperties { get ; set; }
  
  public PictureOptions? PictureOptions { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
