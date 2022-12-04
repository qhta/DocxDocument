namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public class GradientFill
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public TileFlipKind? Flip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public GradientStopList? GradientStopList
  {
    get;
    set;
  }
  
  public LinearGradientFill? LinearGradientFill
  {
    get;
    set;
  }
  
  public PathGradientFill? PathGradientFill
  {
    get;
    set;
  }
  
}
