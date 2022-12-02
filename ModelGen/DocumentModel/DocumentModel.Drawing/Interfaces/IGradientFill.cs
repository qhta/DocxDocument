namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public interface IGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public TileFlipKind? Flip { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public IGradientStopList? GradientStopList { get ; set; }
  
  public ILinearGradientFill? LinearGradientFill { get ; set; }
  
  public IPathGradientFill? PathGradientFill { get ; set; }
  
  public IRelativeRectangleType? TileRectangle { get ; set; }
  
}
