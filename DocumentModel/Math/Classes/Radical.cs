namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Radical Function.
/// </summary>
public class Radical: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Radical Properties.
  /// </summary>
  public RadicalProperties? RadicalProperties { get; set; }

  /// <summary>
  ///   Degree.
  /// </summary>
  public Degree? Degree { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}