namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public interface IGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public TileFlipValues? Flip { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public IGradientStopList? GradientStopList { get ; set; }
  
}
