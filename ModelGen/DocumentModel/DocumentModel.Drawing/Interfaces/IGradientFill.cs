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
  public DocumentModel.BaseTypes.ModelElement? GradientStopList { get ; set; }
  
}
