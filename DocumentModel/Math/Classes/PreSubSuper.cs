namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Pre-Sub-Superscript Function.
/// </summary>
public class PreSubSuper: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Pre-Sub-Superscript Properties.
  /// </summary>
  public PreSubSuperProperties? PreSubSuperProperties { get; set; }

  /// <summary>
  ///   Subscript (Pre-Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument { get; set; }

  /// <summary>
  ///   Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}