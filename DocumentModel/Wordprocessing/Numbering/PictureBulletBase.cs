using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PictureBulletBase Class.
/// </summary>
public class PictureBulletBase: ModelElement
{
  public DocumentModel.Vml.Group? Group { get; set; }

  public ImageFile? ImageFile { get; set; }

  public ILine? ILine { get; set; }

  public Oval? Oval { get; set; }

  public PolyLine? PolyLine { get; set; }

  public IRectangle? IRectangle { get; set; }

  public RoundRectangle? RoundRectangle { get; set; }

  public IShape? IShape { get; set; }

  public Shapetype? Shapetype { get; set; }
}
