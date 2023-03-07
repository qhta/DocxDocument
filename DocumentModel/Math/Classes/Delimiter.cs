namespace DocumentModel.Math;

/// <summary>
///   Delimiter Function.
/// </summary>
public class Delimiter: DMW.IParagraphElement
{
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties { get; set; }

  public Collection<Base>? Bases { get; set; }
}