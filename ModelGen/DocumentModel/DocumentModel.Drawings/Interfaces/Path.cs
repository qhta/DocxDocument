namespace DocumentModel.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public interface Path
{
  /// <summary>
  /// Path Width
  /// </summary>
  public Int64? Width { get ; set; }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public Int64? Height { get ; set; }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public PathFillMode? Fill { get ; set; }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public Boolean? Stroke { get ; set; }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk { get ; set; }
  
  public Collection<Boolean>? CloseShapePaths { get ; set; }
  
  public Collection<MoveTo>? MoveTos { get ; set; }
  
  public Collection<LineTo>? LineTos { get ; set; }
  
  public Collection<ArcTo>? ArcTos { get ; set; }
  
  public Collection<QuadraticBezierCurveTo>? QuadraticBezierCurveTos { get ; set; }
  
  public Collection<CubicBezierCurveTo>? CubicBezierCurveTos { get ; set; }
  
}
