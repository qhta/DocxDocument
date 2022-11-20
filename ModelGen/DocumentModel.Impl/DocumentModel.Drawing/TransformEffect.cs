namespace DocumentModel.Drawing;

/// <summary>
/// Transform Effect.
/// </summary>
public class TransformEffect: ITransformEffect
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public int? HorizontalRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public int? VerticalRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public int? HorizontalSkew
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public int? VerticalSkew
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  public long? HorizontalShift
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  public long? VerticalShift
  {
    get;
    set;
  }
  
}
