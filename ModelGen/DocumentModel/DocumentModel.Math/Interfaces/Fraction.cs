namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public partial interface Fraction
{
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  public DocumentModel.Math.FractionProperties? FractionProperties { get; set; }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  public DocumentModel.Math.Numerator? Numerator { get; set; }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  public DocumentModel.Math.Denominator? Denominator { get; set; }
  
}
