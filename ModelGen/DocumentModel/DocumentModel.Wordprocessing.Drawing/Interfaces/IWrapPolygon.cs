namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public interface IWrapPolygon // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  public Boolean? Edited { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public IPoint2DType? StartPoint { get ; set; }
  
  public Collection<IPoint2DType>? LineTos { get ; set; }
  
}
