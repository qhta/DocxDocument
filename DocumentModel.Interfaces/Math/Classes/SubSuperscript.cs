namespace DocumentModel.Math;

/// <summary>
///   Sub-Superscript Function.
/// </summary>
public class SubSuperscript: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  public SubSuperscriptProperties? SubSuperscriptProperties { get; set; }
  /// <summary>
  ///   Base argument.
  /// </summary>
  public Argument? Base { get; set; }
  /// <summary>
  ///   Subscript (Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument { get; set; }
  /// <summary>
  ///   Superscript (Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }
}