namespace DocumentModel.Drawing;

/// <summary>
/// Horizontal Ratio.
/// </summary>
public class ScaleX: IScaleX
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
