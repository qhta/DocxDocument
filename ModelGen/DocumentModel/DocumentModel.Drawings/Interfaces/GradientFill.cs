namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public interface GradientFill
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
  public GradientStopList? GradientStopList { get ; set; }
  
  public LinearGradientFill? LinearGradientFill { get ; set; }
  
  public PathGradientFill? PathGradientFill { get ; set; }
  
  public RelativeRectangleType? TileRectangle { get ; set; }
  
}
