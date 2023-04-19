namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Path.
/// </summary>
public class Path: ModelElement
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
  public bool? Stroke { get; set; }

  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  public bool? ExtrusionOk { get; set; }

  public bool? CloseShapePath { get; set; }

  public MoveTo? MoveTo { get; set; }

  public LineTo? LineTo { get; set; }

  public ArcTo? ArcTo { get; set; }

  public QuadraticBezierCurveTo? QuadraticBezierCurveTo { get; set; }

  public CubicBezierCurveTo? CubicBezierCurveTo { get; set; }
}