namespace DocumentModel.Wordprocessing.Vml;
using DocumentModel.Vml;

/// <summary>
/// Represents the base definition for a picture bullet in a WordprocessingML document.
/// This interface provides properties for various VML shapes and image elements that can be used as the visual representation of a picture bullet, enabling advanced customization of list bullets using images and vector graphics.
/// </summary>
public partial class PictureBulletBase : ModelElement
{
  /// <summary>
  /// VML group element containing multiple shapes or elements for the picture bullet.
  /// </summary>
  public Group? Group { get; set; }
  /// <summary>
  /// Image file element specifying the image used for the picture bullet.
  /// </summary>
  public ImageFile? ImageFile { get; set; }
  /// <summary>
  /// VML line element used as the picture bullet.
  /// </summary>
  public Line? Line { get; set; }
  /// <summary>
  /// VML oval element used as the picture bullet.
  /// </summary>
  public Oval? Oval { get; set; }
  /// <summary>
  /// VML polyline element used as the picture bullet.
  /// </summary>
  public PolyLine? PolyLine { get; set; }
  /// <summary>
  /// VML rectangle element used as the picture bullet.
  /// </summary>
  public Rectangle? Rectangle { get; set; }
  /// <summary>
  /// VML round rectangle element used as the picture bullet.
  /// </summary>
  public RoundRectangle? RoundRectangle { get; set; }
  /// <summary>
  /// VML shape element used as the picture bullet.
  /// </summary>
  public Shape? Shape { get; set; }
  /// <summary>
  /// VML shape type element defining the template for the picture bullet.
  /// </summary>
  public ShapeType? ShapeType { get; set; }
}