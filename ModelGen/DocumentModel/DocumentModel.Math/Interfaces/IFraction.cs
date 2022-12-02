namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public interface IFraction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  public IFractionProperties? FractionProperties { get ; set; }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  public INumerator? Numerator { get ; set; }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  public IDenominator? Denominator { get ; set; }
  
}
