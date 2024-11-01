namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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