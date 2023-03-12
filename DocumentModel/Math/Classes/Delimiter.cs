namespace DocumentModel.Math;

/// <summary>
///   Delimiter Function.
/// </summary>
public class Delimiter: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties { get; set; }

  public Collection<Base>? Bases { get; set; }
}