using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PictureBulletBase Class.
/// </summary>
public record PictureBulletBase
{
  public DocumentModel.Vml.Group? Group { get; set; }

  public ImageFile? ImageFile { get; set; }

  public Line? Line { get; set; }

  public Oval? Oval { get; set; }

  public PolyLine? PolyLine { get; set; }

  public Rectangle? Rectangle { get; set; }

  public RoundRectangle? RoundRectangle { get; set; }

  public Shape? Shape { get; set; }

  public Shapetype? Shapetype { get; set; }
}