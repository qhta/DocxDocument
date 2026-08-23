namespace DocumentModel.Drawings;

/// <summary>
///   Represents a shape path, including dimensions, fill and stroke options, and path commands for drawing geometry.
/// </summary>
[OpenXmlType(typeof(DXD.Path))]
[DataContract]
[XmlRoot("Path", Namespace = "DocumentModel.Drawings")]
public partial class Path: ModelElement<DXD.Path>
{
  /// <summary>
  ///   Width of the path.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Path.Width))]
  public Int64? Width
  {
    get => _Width ??= GetProperty<Int64?>(GetUpdatableElement()?.Width);
    set => UpdateField(ref _Width, value, nameof(Width));
  }

  private Int64? _Width;

  /// <summary>
  ///   Height of the path.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Path.Height))]
  public Int64? Height
  {
    get => _Height ??= GetProperty<Int64?>(GetUpdatableElement()?.Height);
    set => UpdateField(ref _Height, value, nameof(Height));
  }

  private Int64? _Height;

  /// <summary>
  ///   Fill mode for the path.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Path.Fill))]
  public PathFillMode? Fill
  {
    get => _Fill ??= GetProperty<PathFillMode?>(GetUpdatableElement()?.Fill);
    set => UpdateField(ref _Fill, value, nameof(Fill));
  }

  private PathFillMode? _Fill;

  /// <summary>
  ///   Indicates whether the path is stroked.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Path.Stroke))]
  public bool? Stroke
  {
    get => _Stroke ??= GetProperty<bool?>(GetUpdatableElement()?.Stroke);
    set => UpdateField(ref _Stroke, value, nameof(Stroke));
  }

  private bool? _Stroke;

  /// <summary>
  ///   Indicates whether 3D extrusion is allowed for the path.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Path.ExtrusionOk))]
  public bool? ExtrusionOk
  {
    get => _ExtrusionOk ??= GetProperty<bool?>(GetUpdatableElement()?.ExtrusionOk);
    set => UpdateField(ref _ExtrusionOk, value, nameof(ExtrusionOk));
  }

  private bool? _ExtrusionOk;

  /// <summary>
  ///   Indicates whether the path should be closed.
  /// </summary>
  public bool? CloseShapePath
  {
    get => _CloseShapePath;
    set => UpdateField(ref _CloseShapePath, value, nameof(CloseShapePath));
  }

  private bool? _CloseShapePath;

  /// <summary>
  ///   Move-to command for the path.
  /// </summary>
  public MoveTo? MoveTo { get => _MoveTo; set => UpdateField(ref _MoveTo, value, nameof(MoveTo)); }

  private MoveTo? _MoveTo;

  /// <summary>
  ///   Line-to command for the path.
  /// </summary>
  public LineTo? LineTo { get => _LineTo; set => UpdateField(ref _LineTo, value, nameof(LineTo)); }

  private LineTo? _LineTo;

  /// <summary>
  ///   Arc-to command for the path.
  /// </summary>
  public ArcTo? ArcTo { get => _ArcTo; set => UpdateField(ref _ArcTo, value, nameof(ArcTo)); }

  private ArcTo? _ArcTo;

  /// <summary>
  ///   Quadratic B�zier curve-to command for the path.
  /// </summary>
  public QuadraticBezierCurveTo? QuadraticBezierCurveTo
  {
    get => _QuadraticBezierCurveTo;
    set => UpdateField(ref _QuadraticBezierCurveTo, value, nameof(QuadraticBezierCurveTo));
  }

  private QuadraticBezierCurveTo? _QuadraticBezierCurveTo;

  /// <summary>
  ///   Cubic B�zier curve-to command for the path.
  /// </summary>
  public CubicBezierCurveTo? CubicBezierCurveTo
  {
    get => _CubicBezierCurveTo;
    set => UpdateField(ref _CubicBezierCurveTo, value, nameof(CubicBezierCurveTo));
  }

  private CubicBezierCurveTo? _CubicBezierCurveTo;
}