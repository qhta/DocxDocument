namespace DocumentModel.Drawing;

/// <summary>
/// Shape Path.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IArcTo))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICloseShapePath))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICubicBezierCurveTo))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineTo))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IMoveTo))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IQuadraticBezierCurveTo))]
public interface IPath // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Path Width
  /// </summary>
  public long? Width { get ; set; }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public long? Height { get ; set; }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public PathFillMode? Fill { get ; set; }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public bool? Stroke { get ; set; }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public bool? ExtrusionOk { get ; set; }
  
}
