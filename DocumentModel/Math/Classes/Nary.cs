namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   n-ary Operator Function.
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