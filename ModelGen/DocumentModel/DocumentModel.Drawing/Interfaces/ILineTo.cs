namespace DocumentModel.Drawing;

/// <summary>
/// Draw Line To.
/// </summary>
public interface ILineTo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Line end point.
  /// </summary>
  public DocumentModel.Drawing.IAdjustPoint2DType? Point { get ; set; }
  
}
