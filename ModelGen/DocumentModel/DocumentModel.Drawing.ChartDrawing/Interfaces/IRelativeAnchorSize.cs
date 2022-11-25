namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface IRelativeAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IMarkerType? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IMarkerType? ToAnchor { get ; set; }
  
}
