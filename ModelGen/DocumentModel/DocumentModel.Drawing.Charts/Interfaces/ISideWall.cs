namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D side wall formatting.
/// </summary>
public interface ISideWall // : DocumentModel.Drawing.Charts.ISurfaceType
{
  public System.Byte? Thickness { get ; set; }
  
  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPictureOptions? PictureOptions { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
