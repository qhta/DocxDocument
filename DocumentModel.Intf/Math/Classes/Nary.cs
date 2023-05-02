namespace DocumentModel.Math;

/// <summary>
///   This element specifies an n-ary object, consisting of an n-ary object, a base (or operand) and optional upper and lower limits.
///   Examples of n-ary objects are: integral, sum, product.
/// </summary>
public class Nary: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   n-ary Properties.
  /// </summary>
  public NaryProperties? NaryProperties { get; set; }

  /// <summary>
  ///   Lower limit (n-ary) .
  /// </summary>
  public SubArgument? SubArgument { get; set; }

  /// <summary>
  ///   Upper limit (n-ary).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }

  /// <summary>
  ///   Base argument.
  /// </summary>
  public Argument? Argument { get; set; }

}