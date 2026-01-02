namespace DocumentModel.Math;
/// <summary>
///   This element specifies the fraction object, consisting of a numerator and denominator separated by a fraction bar. 
///   The fraction bar can be horizontal or diagonal, depending on the fraction properties. 
///   The fraction object is also used to represent the stack function, which places one element above another, with no fraction bar. .
/// </summary>
public class Fraction: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Fraction Properties.
  /// </summary>
  public FractionProperties? FractionProperties { get; set; }
  /// <summary>
  ///   Numerator.
  /// </summary>
  public Numerator? Numerator { get; set; }
  /// <summary>
  ///   Denominator.
  /// </summary>
  public Denominator? Denominator { get; set; }
}