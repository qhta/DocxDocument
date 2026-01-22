namespace DocumentModel.Drawings;
/// <summary>
///   Represents a shape path, including dimensions, fill and stroke options, and path commands for drawing geometry.
/// </summary>
public partial class Path : ModelElement<DXD.Path>
{
    /// <summary>
    ///   Width of the path.
    /// </summary>
    public Int64? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private Int64? _Width;
    /// <summary>
    ///   Height of the path.
    /// </summary>
    public Int64? Height { get; set; }
    /// <summary>
    ///   Fill mode for the path.
    /// </summary>
    public PathFillMode? Fill { get; set; }
    /// <summary>
    ///   Indicates whether the path is stroked.
    /// </summary>
    public bool? Stroke { get; set; }
    /// <summary>
    ///   Indicates whether 3D extrusion is allowed for the path.
    /// </summary>
    public bool? ExtrusionOk { get; set; }
    /// <summary>
    ///   Indicates whether the path should be closed.
    /// </summary>
    public bool? CloseShapePath { get; set; }
    /// <summary>
    ///   Move-to command for the path.
    /// </summary>
    public MoveTo? MoveTo { get; set; }
    /// <summary>
    ///   Line-to command for the path.
    /// </summary>
    public LineTo? LineTo { get; set; }
    /// <summary>
    ///   Arc-to command for the path.
    /// </summary>
    public ArcTo? ArcTo { get; set; }
    /// <summary>
    ///   Quadratic B�zier curve-to command for the path.
    /// </summary>
    public QuadraticBezierCurveTo? QuadraticBezierCurveTo { get; set; }
    /// <summary>
    ///   Cubic B�zier curve-to command for the path.
    /// </summary>
    public CubicBezierCurveTo? CubicBezierCurveTo { get; set; }
}