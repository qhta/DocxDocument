namespace DocumentModel.Drawing;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public class LinearGradientFill: ILinearGradientFill
{
  /// <summary>
  /// Angle
  /// </summary>
  public int? Angle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public bool? Scaled
  {
    get;
    set;
  }
  
}
