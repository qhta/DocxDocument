namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the SxRatio Class.
/// </summary>
public interface ISxRatio // : DocumentFormat.OpenXml.Office2019.Drawing.Model3D.RatioType
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
