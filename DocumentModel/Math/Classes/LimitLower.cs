namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Lower-Limit Function.
/// </summary>
public class LimitLower: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  public LimitLowerProperties? LimitLowerProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }

  /// <summary>
  ///   Limit (Lower).
  /// </summary>
  public Limit? Limit { get; set; }
}