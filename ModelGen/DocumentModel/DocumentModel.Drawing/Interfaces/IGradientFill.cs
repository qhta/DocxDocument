namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientStopList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILinearGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPathGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITileRectangle))]
public interface IGradientFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public TileFlipValues? Flip { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public bool? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public DocumentModel.Drawing.IGradientStopList? GradientStopList { get ; set; }
  
}
