namespace DocumentModel.Math;

/// <summary>
///   n-ary Operator Function.
/// </summary>
public class Nary: ICommonMathElement
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
  ///   Base (Argument).
  /// </summary>
  public Base? Base { get; set; }
}