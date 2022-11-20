namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the SyRatio Class.
/// </summary>
public interface ISyRatio // : DocumentFormat.OpenXml.Office2019.Drawing.Model3D.RatioType
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
