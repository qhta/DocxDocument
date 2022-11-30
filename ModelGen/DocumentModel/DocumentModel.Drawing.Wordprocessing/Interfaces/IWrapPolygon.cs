namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public interface IWrapPolygon // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  public System.Boolean? Edited { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IPoint2DType? StartPoint { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Wordprocessing.IPoint2DType>? LineTos { get ; set; }
  
}
