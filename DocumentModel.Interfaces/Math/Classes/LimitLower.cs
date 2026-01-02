namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Lower-Limit object, consisting of text on the baseline 
///   and reduced-size text immediately below it. Examples of limLow include lim and max.
/// </summary>
public class LimitLower: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  public LimitLowerProperties? LimitLowerProperties { get; set; }
  /// <summary>
  ///   argument.
  /// </summary>
  public Argument? Argument { get; set; }
  /// <summary>
  ///   Limit (lower.
  /// </summary>
  public Limit? Limit { get; set; }
}