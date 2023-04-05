namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }

  /// <summary>
  ///   Subscript (Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument { get; set; }

  /// <summary>
  ///   Superscript (Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }
}