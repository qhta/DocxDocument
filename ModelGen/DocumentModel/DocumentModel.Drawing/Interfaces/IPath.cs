namespace DocumentModel.Drawing;

/// <summary>
/// Shape Path.
/// </summary>
public interface IPath // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Path Width
  /// </summary>
  public System.Int64? Width { get ; set; }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public System.Int64? Height { get ; set; }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public DocumentModel.Drawing.PathFillMode? Fill { get ; set; }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public System.Boolean? Stroke { get ; set; }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public System.Boolean? ExtrusionOk { get ; set; }
  
}
