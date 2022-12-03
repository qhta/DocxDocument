namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public interface PictureBulletBase // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DocumentModel.Vml.Group>? Groups { get ; set; }
  
  public Collection<DocumentModel.Vml.ImageFile>? ImageFiles { get ; set; }
  
  public Collection<DocumentModel.Vml.Line>? Lines { get ; set; }
  
  public Collection<DocumentModel.Vml.Oval>? Ovals { get ; set; }
  
  public Collection<DocumentModel.Vml.PolyLine>? PolyLines { get ; set; }
  
  public Collection<DocumentModel.Vml.Rectangle>? Rectangles { get ; set; }
  
  public Collection<DocumentModel.Vml.RoundRectangle>? RoundRectangles { get ; set; }
  
  public Collection<DocumentModel.Vml.Shape>? Shapes { get ; set; }
  
  public Collection<DocumentModel.Vml.Shapetype>? Shapetypes { get ; set; }
  
}
