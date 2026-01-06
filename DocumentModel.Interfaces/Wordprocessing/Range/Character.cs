namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single character in a document.
/// </summary>
/// <remarks>
///   A character can be a text character, whitespace, punctuation, or special
///   formatting mark like a tab or paragraph mark.
/// </remarks>
public interface Character
{
  #region Text Content

  /// <summary>
  ///   Gets or sets the character text.
  /// </summary>
  public string? Text { get; set; }

  /// <summary>
  ///   Gets the Unicode code point of the character.
  /// </summary>
  public int? Code { get; }

  #endregion

  #region Range Properties

  /// <summary>
  ///   Gets the range object representing this character.
  /// </summary>
  public Range? Range { get; }

  /// <summary>
  ///   Gets the starting character position.
  /// </summary>
  public int Start { get; }

  /// <summary>
  ///   Gets the ending character position.
  /// </summary>
  public int End { get; }

  #endregion

  #region Formatting

  /// <summary>
  ///   Gets or sets the font formatting for the character.
  /// </summary>
  public TextFormat? Font { get; set; }

  /// <summary>
  ///   Gets or sets whether the character is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Gets or sets whether the character is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Gets or sets the underline style.
  /// </summary>
  public UnderlineKind? Underline { get; set; }

  #endregion

  #region Methods

  /// <summary>
  ///   Selects the character.
  /// </summary>
  public void Select();

  /// <summary>
  ///   Copies the character to the clipboard.
  /// </summary>
  public void Copy();

  /// <summary>
  ///   Deletes the character.
  /// </summary>
  public void Delete();

  /// <summary>
  ///   Inserts text before the character.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertBefore(string text);

  /// <summary>
  ///   Inserts text after the character.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertAfter(string text);

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent object containing this character.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}