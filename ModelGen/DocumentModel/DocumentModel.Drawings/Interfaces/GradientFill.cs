namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public interface GradientFill
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public DocumentModel.Drawings.TileFlipKind? Flip { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public DocumentModel.Drawings.GradientStopList? GradientStopList { get ; set; }
  
  public DocumentModel.Drawings.LinearGradientFill? LinearGradientFill { get ; set; }
  
  public DocumentModel.Drawings.PathGradientFill? PathGradientFill { get ; set; }
  
  public DocumentModel.Drawings.RelativeRectangleType? TileRectangle { get ; set; }
  
}
