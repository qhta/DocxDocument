namespace DocumentModel.Math;

/// <summary>
///   Upper-Limit Function.
/// </summary>
public class LimitUpper: DMW.IParagraphElement
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