namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IStartPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.ILineTo))]
public interface IWrapPolygon // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  public bool? Edited { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public IStartPoint? StartPoint { get ; set; }
  
}
