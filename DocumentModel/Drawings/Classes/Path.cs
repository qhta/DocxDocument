namespace DocumentModel.Drawings;

/// <summary>
///   Shape Path.
/// </summary>
public record Path
{
  /// <summary>
  ///   Path Width
  /// </summary>
  public Int64? Width { get; set; }

  /// <summary>
  ///   Path Height
  /// </summary>
  public Int64? Height { get; set; }

  /// <summary>
  ///   Path Fill
  /// </summary>
  public PathFillMode? Fill { get; set; }

  /// <summary>
  ///   Path Stroke
  /// </summary>
  public Boolean? Stroke { get; set; }

  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk { get; set; }

  public Boolean? CloseShapePath { get; set; }

  public MoveTo? MoveTo { get; set; }

  public LineTo? LineTo { get; set; }

  public ArcTo? ArcTo { get; set; }

  public QuadraticBezierCurveTo? QuadraticBezierCurveTo { get; set; }

  public CubicBezierCurveTo? CubicBezierCurveTo { get; set; }
}