namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Upper-Limit Function.
/// </summary>
public class LimitUpper: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Upper Limit Properties.
  /// </summary>
  public LimitUpperProperties? LimitUpperProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }

  /// <summary>
  ///   Limit (Upper).
  /// </summary>
  public Limit? Limit { get; set; }
}