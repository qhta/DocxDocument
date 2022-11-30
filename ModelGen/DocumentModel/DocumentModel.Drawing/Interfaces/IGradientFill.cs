namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public interface IGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public DocumentModel.Drawing.TileFlipKind? Flip { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public System.Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public DocumentModel.Drawing.IGradientStopList? GradientStopList { get ; set; }
  
  public DocumentModel.Drawing.ILinearGradientFill? LinearGradientFill { get ; set; }
  
  public DocumentModel.Drawing.IPathGradientFill? PathGradientFill { get ; set; }
  
  public DocumentModel.Drawing.IRelativeRectangleType? TileRectangle { get ; set; }
  
}
