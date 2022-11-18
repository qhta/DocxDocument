namespace DocumentModel.Drawing;

/// <summary>
/// Horizontal Ratio.
/// </summary>
public interface IScaleX // : DocumentFormat.OpenXml.Drawing.RatioType
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
