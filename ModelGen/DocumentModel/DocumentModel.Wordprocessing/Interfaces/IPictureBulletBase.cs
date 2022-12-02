namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public interface IPictureBulletBase // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<DocumentModel.Vml.IGroup>? Groups { get ; set; }
  
  public Collection<DocumentModel.Vml.IImageFile>? ImageFiles { get ; set; }
  
  public Collection<DocumentModel.Vml.ILine>? Lines { get ; set; }
  
  public Collection<DocumentModel.Vml.IOval>? Ovals { get ; set; }
  
  public Collection<DocumentModel.Vml.IPolyLine>? PolyLines { get ; set; }
  
  public Collection<DocumentModel.Vml.IRectangle>? Rectangles { get ; set; }
  
  public Collection<DocumentModel.Vml.IRoundRectangle>? RoundRectangles { get ; set; }
  
  public Collection<DocumentModel.Vml.IShape>? Shapes { get ; set; }
  
  public Collection<DocumentModel.Vml.IShapetype>? Shapetypes { get ; set; }
  
}
