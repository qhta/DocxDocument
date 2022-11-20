namespace DocumentModel.Drawing;

/// <summary>
/// Vertical Ratio.
/// </summary>
public class ScaleY: IScaleY
{
  /// <summary>
  /// Numerator
  /// </summary>
  public int? Numerator
  {
    get;
    set;
  }
  
  /// <summary>
  /// Denominator
  /// </summary>
  public int? Denominator
  {
    get;
    set;
  }
  
}
