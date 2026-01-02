namespace DocumentModel.Math;

/// <summary>
///   Subscript Function.
/// </summary>
public class Subscript: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Subscript Properties.
  /// </summary>
  public SubscriptProperties? SubscriptProperties { get; set; }
  /// <summary>
  ///   Subscript base argument.
  /// </summary>
  public Argument? Argument { get; set; }
  /// <summary>
  ///   Subscript (Subscript function).
  /// </summary>
  public SubArgument? SubArgument { get; set; }
}