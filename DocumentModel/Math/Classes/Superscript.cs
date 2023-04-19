namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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