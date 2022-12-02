namespace DocumentModel.Drawing;

/// <summary>
/// 3D back wall formatting.
/// </summary>
public interface IBackWall // : DocumentModel.Drawing.ISurfaceType
{
  public Byte? Thickness { get ; set; }
  
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public IPictureOptions? PictureOptions { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
