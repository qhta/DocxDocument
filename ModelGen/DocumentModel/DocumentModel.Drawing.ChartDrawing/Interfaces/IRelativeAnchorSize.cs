namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface IRelativeAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public IToAnchor? ToAnchor { get ; set; }
  
}
