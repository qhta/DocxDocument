namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IFractionProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.INumerator))]
[ChildElementInfo(typeof(DocumentModel.Math.IDenominator))]
public interface IFraction // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
