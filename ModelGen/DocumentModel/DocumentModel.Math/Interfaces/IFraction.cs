namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public interface IFraction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  public DocumentModel.Math.IFractionProperties? FractionProperties { get ; set; }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  public DocumentModel.Math.INumerator? Numerator { get ; set; }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  public DocumentModel.Math.IDenominator? Denominator { get ; set; }
  
}
