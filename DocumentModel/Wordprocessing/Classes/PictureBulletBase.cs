namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public partial class PictureBulletBase
{
  public DocumentModel.Vml.Group? Group { get; set; }
  
  public DocumentModel.Vml.ImageFile? ImageFile { get; set; }
  
  public DocumentModel.Vml.Line? Line { get; set; }
  
  public DocumentModel.Vml.Oval? Oval { get; set; }
  
  public DocumentModel.Vml.PolyLine? PolyLine { get; set; }
  
  public DocumentModel.Vml.Rectangle? Rectangle { get; set; }
  
  public DocumentModel.Vml.RoundRectangle? RoundRectangle { get; set; }
  
  public DocumentModel.Vml.Shape? Shape { get; set; }
  
  public DocumentModel.Vml.Shapetype? Shapetype { get; set; }
  
}
