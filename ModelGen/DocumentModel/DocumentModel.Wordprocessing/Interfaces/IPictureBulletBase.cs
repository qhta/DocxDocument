namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public interface IPictureBulletBase // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Vml.IGroup? Group { get ; set; }
  
  public DocumentModel.Vml.IImageFile? ImageFile { get ; set; }
  
  public DocumentModel.Vml.ILine? Line { get ; set; }
  
  public DocumentModel.Vml.IOval? Oval { get ; set; }
  
  public DocumentModel.Vml.IPolyLine? PolyLine { get ; set; }
  
  public DocumentModel.Vml.IRectangle? Rectangle { get ; set; }
  
  public DocumentModel.Vml.IRoundRectangle? RoundRectangle { get ; set; }
  
  public DocumentModel.Vml.IShape? Shape { get ; set; }
  
  public DocumentModel.Vml.IShapetype? Shapetype { get ; set; }
  
}
