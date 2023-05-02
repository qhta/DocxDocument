namespace DocumentModel.Math;

/// <summary>
///   This element specifies the bar function, consisting of a base argument and an overbar or underbar, as in ¯a and _𝑎.
/// </summary>
public class Bar: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Specifies formatting properties of bar function.
  /// </summary>
  public BarProperties? BarProperties { get; set; }

  /// <summary>
  ///   Specifies argument of bar function.
  /// </summary>
  public Argument? Argument { get; set; }
}