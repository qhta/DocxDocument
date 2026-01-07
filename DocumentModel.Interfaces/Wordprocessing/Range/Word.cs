namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single word in a document.
/// </summary>
/// <remarks>
///   <para>
///   A Word is a specialized Range that represents a sequence of characters
///   bounded by whitespace, punctuation, or other word delimiters.
///   </para>
///   <para>
///   Word boundary rules vary by language:
///   <list type="bullet">
///   <item><description><b>English and European languages:</b> Whitespace and punctuation separate words</description></item>
///   <item><description><b>Chinese and Japanese:</b> No spaces between words; requires dictionary-based segmentation</description></item>
///   <item><description><b>Thai:</b> No spaces between words; uses specialized word-breaking algorithms</description></item>
///   </list>
///   </para>
/// </remarks>
public interface Word: CollectionItem
{
  #region Text Content

  /// <summary>
  ///   Gets or sets the text content of the word.
  /// </summary>
  public string? Text { get; set; }

  /// <summary>
  ///   Gets the plain text of the word without formatting.
  /// </summary>
  public string? PlainText { get; }

  #endregion

  #region Range Properties

  /// <summary>
  ///   Gets the range object representing this word.
  /// </summary>
  public Range? Range { get; }

  /// <summary>
  ///   Gets the starting character position of the word.
  /// </summary>
  public int Start { get; }

  /// <summary>
  ///   Gets the ending character position of the word.
  /// </summary>
  public int End { get; }

  /// <summary>
  ///   Gets the length of the word in characters.
  /// </summary>
  public int Length { get; }

  #endregion

  #region Formatting

  /// <summary>
  ///   Gets or sets the font formatting for the word.
  /// </summary>
  public TextFormat? Font { get; set; }

  /// <summary>
  ///   Gets or sets the language ID for the word.
  /// </summary>
  public int? LanguageID { get; set; }

  /// <summary>
  ///   Gets or sets whether the word is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Gets or sets whether the word is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Gets or sets the underline style.
  /// </summary>
  public UnderlineKind? Underline { get; set; }

  #endregion

  #region Character Collection

  /// <summary>
  ///   Gets the collection of characters in the word.
  /// </summary>
  public Characters? Characters { get; }

  #endregion

  #region Methods

  /// <summary>
  ///   Selects the word.
  /// </summary>
  public void Select();

  /// <summary>
  ///   Copies the word to the clipboard.
  /// </summary>
  public void Copy();

  /// <summary>
  ///   Cuts the word to the clipboard.
  /// </summary>
  public void Cut();

  /// <summary>
  ///   Deletes the word.
  /// </summary>
  public void Delete();

  /// <summary>
  ///   Inserts text before the word.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertBefore(string text);

  /// <summary>
  ///   Inserts text after the word.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertAfter(string text);

  #endregion

  #region Proofing

  /// <summary>
  ///   Gets whether the word is misspelled.
  /// </summary>
  public bool IsMisspelled { get; }

  /// <summary>
  ///   Gets spelling suggestions for the word.
  /// </summary>
  /// <returns>Collection of suggested spellings.</returns>
  public SpellingSuggestions? GetSpellingSuggestions();

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent object containing this word.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}