namespace DocumentModel.Drawings;
/// <summary>
///   Defines the GradientFill Class.
/// </summary>
public abstract class GradientFill: Fill
{
  /// <summary>
  ///   Tile Flip
  /// </summary>
  public TileFlipKind? Flip { get; set; }
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public bool? RotateWithShape { get; set; }
  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  public GradientStopList? GradientStopList { get; set; }
  /// <summary>
  /// Relative rectangle coordinates.
  /// </summary>
  public RelativeRectangleType? TileRectangle { get; set; }
}