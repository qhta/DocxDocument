namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient fill.
/// </summary>
public partial class GradientFill
{
  
  /// <summary>
  ///   Specifies the direction(s) in which to flip the gradient while tiling.
  /// </summary>
  public TileFlipKind? Flip { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
  
  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  public GradientStopList? GradientStopList { get; set; }
  
  public LinearGradientFill? LinearGradientFill { get; set; }
  
  public PathGradientFill? PathGradientFill { get; set; }
  
  public RelativeRectangleType? TileRectangle { get; set; }
  
}
