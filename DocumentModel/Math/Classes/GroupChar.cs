namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Group-Character Function.
/// </summary>
public class GroupChar: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  public GroupCharProperties? GroupCharProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}