namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public interface Fraction // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  public FractionProperties? FractionProperties { get ; set; }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  public Numerator? Numerator { get ; set; }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  public Denominator? Denominator { get ; set; }
  
}
