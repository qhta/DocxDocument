namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Equation-Array Function.
/// </summary>
public class EquationArray: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Equation Array Properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties { get; set; }

  public Collection<Base>? Bases { get; set; }
}