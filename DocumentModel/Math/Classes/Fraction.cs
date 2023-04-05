namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Fraction Function.
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