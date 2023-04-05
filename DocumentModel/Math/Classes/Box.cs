namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Box Function.
/// </summary>
public class Box: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Box Properties.
  /// </summary>
  public BoxProperties? BoxProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}