namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the SzRatio Class.
/// </summary>
public interface ISzRatio // : DocumentFormat.OpenXml.Office2019.Drawing.Model3D.RatioType
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
