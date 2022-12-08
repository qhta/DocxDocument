namespace DocumentModel.Drawings;

/// <summary>
/// 3D side wall formatting.
/// </summary>
public interface SideWall
{
  public Byte? Thickness { get ; set; }
  
  public ShapeProperties1? ShapeProperties { get ; set; }
  
  public PictureOptions? PictureOptions { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
