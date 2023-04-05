namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Delimiter Function.
/// </summary>
public class Delimiter: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties { get; set; }

  public Collection<Base>? Bases { get; set; }
}