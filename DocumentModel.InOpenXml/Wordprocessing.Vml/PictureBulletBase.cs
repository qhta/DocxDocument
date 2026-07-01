namespace DocumentModel.Wordprocessing.Vml;
using DocumentModel.Vml;

/// <summary>
/// Represents the base definition for a picture bullet in a WordprocessingML document.
/// This class provides properties for various VML shapes and image elements that can be used as the visual representation of a picture bullet, enabling advanced customization of list bullets using images and vector graphics.
/// </summary>
[OpenXmlType(typeof(DXW.PictureBulletBase))]
[DataContract]
[XmlRoot("PictureBulletBase", Namespace = "DocumentModel.Wordprocessing.Vml")]
public partial class PictureBulletBase : ModelElement<DXW.PictureBulletBase>
{
 /// <summary>
 /// VML group element containing multiple shapes or elements for the picture bullet.
 /// </summary>
 public Group? Group { get => _Group; set => UpdateField(ref _Group, value, nameof(Group)); }
 private Group? _Group;

 /// <summary>
 /// Image file element specifying the image used for the picture bullet.
 /// </summary>
 public ImageFile? ImageFile { get => _ImageFile; set => UpdateField(ref _ImageFile, value, nameof(ImageFile)); }
 private ImageFile? _ImageFile;

 /// <summary>
 /// VML line element used as the picture bullet.
 /// </summary>
 public Line? Line { get => _Line; set => UpdateField(ref _Line, value, nameof(Line)); }
 private Line? _Line;

 /// <summary>
 /// VML oval element used as the picture bullet.
 /// </summary>
 public Oval? Oval { get => _Oval; set => UpdateField(ref _Oval, value, nameof(Oval)); }
 private Oval? _Oval;

 /// <summary>
 /// VML polyline element used as the picture bullet.
 /// </summary>
 public PolyLine? PolyLine { get => _PolyLine; set => UpdateField(ref _PolyLine, value, nameof(PolyLine)); }
 private PolyLine? _PolyLine;

 /// <summary>
 /// VML rectangle element used as the picture bullet.
 /// </summary>
 public Rectangle? Rectangle { get => _Rectangle; set => UpdateField(ref _Rectangle, value, nameof(Rectangle)); }
 private Rectangle? _Rectangle;

 /// <summary>
 /// VML round rectangle element used as the picture bullet.
 /// </summary>
 public RoundRectangle? RoundRectangle { get => _RoundRectangle; set => UpdateField(ref _RoundRectangle, value, nameof(RoundRectangle)); }
 private RoundRectangle? _RoundRectangle;

 /// <summary>
 /// VML shape element used as the picture bullet.
 /// </summary>
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }
 private Shape? _Shape;

 /// <summary>
 /// VML shape type element defining the template for the picture bullet.
 /// </summary>
 public ShapeType? ShapeType { get => _ShapeType; set => UpdateField(ref _ShapeType, value, nameof(ShapeType)); }
 private ShapeType? _ShapeType;
}