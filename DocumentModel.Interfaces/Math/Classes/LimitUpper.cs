namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Upper-Limit object, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
public class LimitUpper: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Upper Limit Properties.
  /// </summary>
  public LimitUpperProperties? LimitUpperProperties { get; set; }
  /// <summary>
  ///   Argument.
  /// </summary>
  public Argument? Argument { get; set; }
  /// <summary>
  ///   Limit (Upper).
  /// </summary>
  public Limit? Limit { get; set; }
}