namespace DocumentModel.Math;

/// <summary>
///   Subscript Function.
/// </summary>
public interface Subscript: CommonMathContent
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