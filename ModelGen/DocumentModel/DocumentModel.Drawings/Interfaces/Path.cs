namespace DocumentModel.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public partial interface Path
{
  /// <summary>
  /// Path Width
  /// </summary>
  public Int64? Width { get; set; }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public Int64? Height { get; set; }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public DocumentModel.Drawings.PathFillMode? Fill { get; set; }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public Boolean? Stroke { get; set; }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk { get; set; }
  
  public Boolean? CloseShapePath { get; set; }
  
  public DocumentModel.Drawings.MoveTo? MoveTo { get; set; }
  
  public DocumentModel.Drawings.LineTo? LineTo { get; set; }
  
  public DocumentModel.Drawings.ArcTo? ArcTo { get; set; }
  
  public DocumentModel.Drawings.QuadraticBezierCurveTo? QuadraticBezierCurveTo { get; set; }
  
  public DocumentModel.Drawings.CubicBezierCurveTo? CubicBezierCurveTo { get; set; }
  
}
