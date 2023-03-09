namespace DocumentModel.Math;

/// <summary>
///   Subscript Function.
/// </summary>
public class Subscript: ICommonMathElement
{
  /// <summary>
  ///   Subscript Properties.
  /// </summary>
  public SubscriptProperties? SubscriptProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }

  /// <summary>
  ///   Subscript (Subscript function).
  /// </summary>
  public SubArgument? SubArgument { get; set; }
}