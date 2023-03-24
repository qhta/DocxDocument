namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Phantom Function.
/// </summary>
public class Phantom: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  public PhantomProperties? PhantomProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}