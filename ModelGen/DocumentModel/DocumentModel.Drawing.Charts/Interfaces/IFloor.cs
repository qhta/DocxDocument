namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D floor formatting.
/// </summary>
public interface IFloor // : DocumentModel.Drawing.Charts.ISurfaceType
{
  public System.Byte? Thickness { get ; set; }
  
  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPictureOptions? PictureOptions { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
