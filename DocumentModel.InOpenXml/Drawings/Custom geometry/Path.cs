namespace DocumentModel.Drawings;
/// <summary>
///   Represents a shape path, including dimensions, fill and stroke options, and path commands for drawing geometry.
/// </summary>
[OpenXmlType(typeof(DXD.Path))]
public partial class Path : ModelElement<DXD.Path>
{
 /// <summary>
 ///   Width of the path.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Path.Width))]
 /// <summary>
 ///   Width of the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public Int64? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private Int64? _Width;
 /// <summary>
 ///   Height of the path.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Path.Height))]
 /// <summary>
 ///   Height of the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public Int64? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

 private Int64? _Height;
 /// <summary>
 ///   Fill mode for the path.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Path.Fill))]
 /// <summary>
 ///   Fill mode for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public PathFillMode? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private PathFillMode? _Fill;
 /// <summary>
 ///   Indicates whether the path is stroked.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Path.Stroke))]
 /// <summary>
 ///   Indicates whether the path is stroked.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public bool? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

 private bool? _Stroke;
 /// <summary>
 ///   Indicates whether 3D extrusion is allowed for the path.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Path.ExtrusionOk))]
 /// <summary>
 ///   Indicates whether 3D extrusion is allowed for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public bool? ExtrusionOk { get => _ExtrusionOk; set => UpdateField(ref _ExtrusionOk, value, nameof(ExtrusionOk)); }

 private bool? _ExtrusionOk;
 /// <summary>
 ///   Indicates whether the path should be closed.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public bool? CloseShapePath { get => _CloseShapePath; set => UpdateField(ref _CloseShapePath, value, nameof(CloseShapePath)); }

 private bool? _CloseShapePath;
 /// <summary>
 ///   Move-to command for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public MoveTo? MoveTo { get => _MoveTo; set => UpdateField(ref _MoveTo, value, nameof(MoveTo)); }

 private MoveTo? _MoveTo;
 /// <summary>
 ///   Line-to command for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public LineTo? LineTo { get => _LineTo; set => UpdateField(ref _LineTo, value, nameof(LineTo)); }

 private LineTo? _LineTo;
 /// <summary>
 ///   Arc-to command for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public ArcTo? ArcTo { get => _ArcTo; set => UpdateField(ref _ArcTo, value, nameof(ArcTo)); }

 private ArcTo? _ArcTo;
 /// <summary>
 ///   Quadratic B�zier curve-to command for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public QuadraticBezierCurveTo? QuadraticBezierCurveTo { get => _QuadraticBezierCurveTo; set => UpdateField(ref _QuadraticBezierCurveTo, value, nameof(QuadraticBezierCurveTo)); }

 private QuadraticBezierCurveTo? _QuadraticBezierCurveTo;
 /// <summary>
 ///   Cubic B�zier curve-to command for the path.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Path))]
 public CubicBezierCurveTo? CubicBezierCurveTo { get => _CubicBezierCurveTo; set => UpdateField(ref _CubicBezierCurveTo, value, nameof(CubicBezierCurveTo)); }

 private CubicBezierCurveTo? _CubicBezierCurveTo;
}