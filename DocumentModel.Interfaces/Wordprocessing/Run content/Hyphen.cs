namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a hyphen in a text run. 
///   There are two complementary ways to specific a character code of the hyphen: 
///   with enum typed HyphenKind or with a text string.
/// </summary>
public interface Hyphen : RunContent
{
  /// <summary>
  /// Encoded char value of the hyphen.
  /// </summary>
  public HyphenKind? Value { get; set; }

  /// <summary>
  /// Visual text value.
  /// </summary>
  public string Text { get; set; }

}