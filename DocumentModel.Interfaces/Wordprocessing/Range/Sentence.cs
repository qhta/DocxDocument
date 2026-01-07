namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single sentence in a document.
/// </summary>
/// <remarks>
///   <para>
///   A Sentence is a specialized Range that represents text from the beginning of a sentence
///   to its ending punctuation mark. Sentence boundaries are determined by language-specific
///   rules for sentence-ending punctuation.
///   </para>
///   <para>
///   Typical sentence endings include:
///   <list type="bullet">
///   <item><description>Period (.) - Most common sentence terminator</description></item>
///   <item><description>Exclamation mark (!) - Emphatic or exclamatory sentences</description></item>
///   <item><description>Question mark (?) - Interrogative sentences</description></item>
///   <item><description>Language-specific marks (e.g., ؟ in Arabic, ？ in Chinese)</description></item>
///   </list>
///   </para>
///   <para>
///   The sentence detection algorithm considers:
///   <list type="bullet">
///   <item><description>Abbreviations (e.g., "Dr.", "etc.") that don't end sentences</description></item>
///   <item><description>Decimal numbers (e.g., "3.14") where periods aren't sentence boundaries</description></item>
///   <item><description>Ellipses (...) which may or may not indicate sentence breaks</description></item>
///   <item><description>Quotation marks and their interaction with sentence punctuation</description></item>
///   </list>
///   </para>
/// </remarks>
public interface Sentence: CollectionItem
{
  #region Text Content

  /// <summary>
  ///   Gets or sets the text content of the sentence.
  /// </summary>
  /// <remarks>
  ///   Includes the sentence-ending punctuation mark.
  /// </remarks>
  public string? Text { get; set; }

  /// <summary>
  ///   Gets the plain text of the sentence without any formatting.
  /// </summary>
  public string? PlainText { get; }

  #endregion

  #region Range Properties

  /// <summary>
  ///   Gets the range object representing this sentence.
  /// </summary>
  /// <remarks>
  ///   Provides access to full Range functionality for manipulating the sentence.
  /// </remarks>
  public Range? Range { get; }

  /// <summary>
  ///   Gets the starting character position of the sentence.
  /// </summary>
  public int Start { get; }

  /// <summary>
  ///   Gets the ending character position of the sentence.
  /// </summary>
  public int End { get; }

  /// <summary>
  ///   Gets the length of the sentence in characters.
  /// </summary>
  public int Length { get; }

  #endregion

  #region Formatting

  /// <summary>
  ///   Gets or sets the font formatting for the sentence.
  /// </summary>
  public TextFormat? Font { get; set; }

  /// <summary>
  ///   Gets or sets the language ID for the sentence.
  /// </summary>
  /// <remarks>
  ///   Determines which language rules are used for spell checking and grammar.
  /// </remarks>
  public int? LanguageID { get; set; }

  /// <summary>
  ///   Gets or sets whether the sentence text is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Gets or sets whether the sentence text is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Gets or sets the underline style for the sentence.
  /// </summary>
  public UnderlineKind? Underline { get; set; }

  #endregion

  #region Word Collections

  /// <summary>
  ///   Gets the collection of words in the sentence.
  /// </summary>
  public Words? Words { get; }

  /// <summary>
  ///   Gets the collection of characters in the sentence.
  /// </summary>
  public Characters? Characters { get; }

  #endregion

  #region Methods

  /// <summary>
  ///   Selects the sentence.
  /// </summary>
  public void Select();

  /// <summary>
  ///   Copies the sentence to the clipboard.
  /// </summary>
  public void Copy();

  /// <summary>
  ///   Cuts the sentence to the clipboard.
  /// </summary>
  public void Cut();

  /// <summary>
  ///   Deletes the sentence.
  /// </summary>
  public void Delete();

  /// <summary>
  ///   Inserts text before the sentence.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertBefore(string text);

  /// <summary>
  ///   Inserts text after the sentence.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertAfter(string text);

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent object containing this sentence.
  /// </summary>
  /// <remarks>
  ///   Typically a Range, Sentences collection, or Document.
  /// </remarks>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}