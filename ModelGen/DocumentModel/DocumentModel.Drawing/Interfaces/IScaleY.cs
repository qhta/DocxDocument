namespace DocumentModel.Drawing;

/// <summary>
/// Vertical Ratio.
/// </summary>
public interface IScaleY // : DocumentFormat.OpenXml.Drawing.RatioType
{
  /// <summary>
  /// Numerator
  /// </summary>
  public int? Numerator { get ; set; }
  
  /// <summary>
  /// Denominator
  /// </summary>
  public int? Denominator { get ; set; }
  
}
