namespace DocumentModel.Drawing;

/// <summary>
/// 3D back wall formatting.
/// </summary>
public interface IBackWall // : DocumentModel.Drawing.ISurfaceType
{
  public System.Byte? Thickness { get ; set; }
  
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.IPictureOptions? PictureOptions { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
