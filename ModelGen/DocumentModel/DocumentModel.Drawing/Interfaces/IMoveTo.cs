namespace DocumentModel.Drawing;

/// <summary>
/// Move Path To.
/// </summary>
public interface IMoveTo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Move end point.
  /// </summary>
  public DocumentModel.Drawing.IAdjustPoint2DType? Point { get ; set; }
  
}
