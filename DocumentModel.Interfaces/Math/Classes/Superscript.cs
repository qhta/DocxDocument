namespace DocumentModel.Math;

/// <summary>
///   Superscript Function.
/// </summary>
public class Superscript: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Superscript Properties.
  /// </summary>
  public SuperscriptProperties? SuperscriptProperties { get; set; }
  /// <summary>
  ///   Superscript base argument
  /// </summary>
  public Argument? Argument { get; set; }
  /// <summary>
  ///   Superscript (Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }
}