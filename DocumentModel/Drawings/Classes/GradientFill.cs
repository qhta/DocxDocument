namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GradientFill Class.
/// </summary>
public class GradientFill: ModelElement
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

  public LinearGradientFill? LinearGradientFill { get; set; }

  public PathGradientFill? PathGradientFill { get; set; }

  public RelativeRectangleType? TileRectangle { get; set; }
}