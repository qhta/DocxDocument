namespace DocumentModel.Drawings;

/// <summary>
///   Represents a shape path, including dimensions, fill and stroke options, and path commands for drawing geometry.
/// </summary>
public interface Path: CollectionItem
{
  /// <summary>
  ///   Width of the path.
  /// </summary>
  public Int64? Width { get; set; }

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
  ///   Quadratic Bézier curve-to command for the path.
  /// </summary>
  public QuadraticBezierCurveTo? QuadraticBezierCurveTo { get; set; }

  /// <summary>
  ///   Cubic Bézier curve-to command for the path.
  /// </summary>
  public CubicBezierCurveTo? CubicBezierCurveTo { get; set; }
}