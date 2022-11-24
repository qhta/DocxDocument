namespace DocumentModel.Drawing;

/// <summary>
/// Shape Path.
/// </summary>
public interface IPath // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public PathFillModeValues? Fill { get ; set; }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public Boolean? Stroke { get ; set; }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk { get ; set; }
  
}
