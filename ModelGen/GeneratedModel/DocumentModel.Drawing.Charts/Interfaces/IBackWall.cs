namespace DocumentModel.Drawing.Charts;

public interface IBackWall // : DocumentFormat.OpenXml.Drawing.Charts.SurfaceType
{
  public IThickness? Thickness { get ; set; }

  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties { get ; set; }

  public IPictureOptions? PictureOptions { get ; set; }

  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }

}
