namespace DocumentModel.Math;

/// <summary>
///   n-ary Operator Function.
/// </summary>
public class Nary: ModelElement, ICommonMathElement
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

  //public override int GetHashCode()
  //{
  //  Debug.Indent();
  //  var hashCode = base.GetHashCode();
  //  Debug.WriteLine($"{this}.HashCode={hashCode}");
  //  Debug.Unindent();
  //  return hashCode;
  //}
}