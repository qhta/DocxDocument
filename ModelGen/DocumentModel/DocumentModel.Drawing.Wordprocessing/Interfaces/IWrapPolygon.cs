namespace DocumentModel.Drawing.Wordprocessing;

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
  public IStartPoint? StartPoint { get ; set; }
  
}
