namespace DocumentModel.Drawings;

/// <summary>
/// 3D floor formatting.
/// </summary>
public interface Floor2
{
  public Byte? Thickness { get ; set; }
  
  public ShapeProperties1? ShapeProperties { get ; set; }
  
  public PictureOptions? PictureOptions { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
