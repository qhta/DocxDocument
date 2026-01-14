namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a hyphen character in a text run in WordprocessingML documents.
/// This interface provides two complementary ways to specify the hyphen: by an enum-typed value or by a visual text string, enabling advanced control over hyphenation and character encoding in document content.
/// </summary>
public interface Hyphen : IRunContent
{
  
  /// <summary>
  /// Encoded character value of the hyphen, specifying the hyphen type using an enumeration.
  /// </summary>
  public HyphenKind? Value { get; set; }
  
  /// <summary>
  /// Visual text value of the hyphen, specifying the actual character or string to display.
  /// </summary>
  public string Text { get; set; }
}