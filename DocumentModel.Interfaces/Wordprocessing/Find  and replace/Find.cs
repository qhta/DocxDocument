using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the find and replace functionality in Word.
/// </summary>
/// <remarks>
///   The Find interface provides comprehensive search capabilities including
///   text search, formatting search, wildcard patterns, and replacement operations.
///   It corresponds to the Microsoft.Office.Interop.Word.Find interface.
/// </remarks>
public interface Find
{
  #region Search Text and Pattern

  /// <summary>
  ///   Gets or sets the text to search for.
  /// </summary>
  /// <remarks>
  ///   This property specifies the literal text or pattern to find in the document.
  ///   Can be combined with wildcards, regular expressions, or special characters.
  /// </remarks>
  public string? Text { get; set; }

  /// <summary>
  ///   Gets or sets the replacement text.
  /// </summary>
  /// <remarks>
  ///   Specifies the text that will replace the found text when Execute is called with replace option.
  /// </remarks>
  public string? ReplacementText { get; set; }

  /// <summary>
  ///   Gets or sets whether the search should continue after reaching the end/beginning of the range.
  /// </summary>
  /// <remarks>
  ///   Controls whether search wraps around to the opposite end of the document when the
  ///   search reaches the end (forward search) or beginning (backward search).
  /// </remarks>
  public WrapKind Wrap { get; set; }

  /// <summary>
  ///   Gets or sets the search direction.
  /// </summary>
  /// <remarks>
  ///   Specifies whether to search forward from the current position or backward.
  /// </remarks>
  public bool Forward { get; set; }

  #endregion

  #region Search Options

  /// <summary>
  ///   Gets or sets whether the search is case-sensitive.
  /// </summary>
  /// <remarks>
  ///   When true, "Word" will not match "word" or "WORD".
  /// </remarks>
  public bool MatchCase { get; set; }

  /// <summary>
  ///   Gets or sets whether to match only whole words.
  /// </summary>
  /// <remarks>
  ///   When true, "port" will not match "report" or "portable".
  ///   The found text must be surrounded by whitespace or punctuation.
  /// </remarks>
  public bool MatchWholeWord { get; set; }

  /// <summary>
  ///   Gets or sets whether to match words that sound similar (English only).
  /// </summary>
  /// <remarks>
  ///   Enables phonetic matching where "their" would match "there" and "they're".
  ///   This feature is primarily for English language searching.
  /// </remarks>
  public bool MatchSoundsLike { get; set; }

  /// <summary>
  ///   Gets or sets whether to match all word forms.
  /// </summary>
  /// <remarks>
  ///   When true, searching for "run" will also find "running", "ran", "runs".
  ///   Uses built-in word stemming for the document language.
  /// </remarks>
  public bool MatchAllWordForms { get; set; }

  /// <summary>
  ///   Gets or sets whether to use wildcards in the search text.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Enables wildcard pattern matching:
  ///   <list type="bullet">
  ///   <item><description>? - Any single character</description></item>
  ///   <item><description>* - Any string of characters</description></item>
  ///   <item><description>[ ] - Any single character in the range</description></item>
  ///   <item><description>[! ] - Any single character not in the range</description></item>
  ///   <item><description>{n} - Exactly n occurrences of the preceding character</description></item>
  ///   <item><description>{n,} - At least n occurrences</description></item>
  ///   <item><description>{n,m} - From n to m occurrences</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public bool MatchWildcards { get; set; }

  /// <summary>
  ///   Gets or sets whether to match control characters and special characters.
  /// </summary>
  /// <remarks>
  ///   Allows searching for special characters like paragraph marks (^p),
  ///   tab characters (^t), line breaks (^l), etc.
  /// </remarks>
  public bool MatchControlCharacters { get; set; }

  /// <summary>
  ///   Gets or sets whether diacritics must match.
  /// </summary>
  /// <remarks>
  ///   When false, "cafe" will match "café". When true, diacritical marks must match exactly.
  /// </remarks>
  public bool MatchDiacritics { get; set; }

  /// <summary>
  ///   Gets or sets whether Alef Hamza characters must match in Arabic text.
  /// </summary>
  /// <remarks>
  ///   Applies to Arabic language searching. When false, different forms of Alef are treated as equivalent.
  /// </remarks>
  public bool MatchAlefHamza { get; set; }

  /// <summary>
  ///   Gets or sets whether kashida characters are considered during Arabic searches.
  /// </summary>
  /// <remarks>
  ///   Applies to Arabic text. Kashidas are elongation characters used for justification.
  /// </remarks>
  public bool MatchKashida { get; set; }

  /// <summary>
  ///   Gets or sets whether search should match prefix of words.
  /// </summary>
  /// <remarks>
  ///   When true, "pre" will match "prefix", "prepare", etc.
  /// </remarks>
  public bool MatchPrefix { get; set; }

  /// <summary>
  ///   Gets or sets whether search should match suffix of words.
  /// </summary>
  /// <remarks>
  ///   When true, "ing" will match "running", "walking", etc.
  /// </remarks>
  public bool MatchSuffix { get; set; }

  /// <summary>
  ///   Gets or sets whether to ignore whitespace characters.
  /// </summary>
  /// <remarks>
  ///   When true, "blue print" will match "blueprint" and "blue  print" (with multiple spaces).
  /// </remarks>
  public bool IgnoreSpace { get; set; }

  /// <summary>
  ///   Gets or sets whether to ignore punctuation characters.
  /// </summary>
  /// <remarks>
  ///   When true, "don't" will match "dont" and "don-t".
  /// </remarks>
  public bool IgnorePunct { get; set; }

  #endregion

  #region Format Finding

  /// <summary>
  ///   Gets or sets the font formatting to search for.
  /// </summary>
  /// <remarks>
  ///   Specifies character formatting criteria like bold, italic, font name, size, color, etc.
  /// </remarks>
  public FontProperties? Font { get; set; }

  /// <summary>
  ///   Gets or sets the paragraph formatting to search for.
  /// </summary>
  /// <remarks>
  ///   Specifies paragraph formatting criteria like alignment, indentation, spacing, etc.
  /// </remarks>
  public ParagraphFormat? ParagraphFormat { get; set; }

  /// <summary>
  ///   Gets or sets the style name to search for.
  /// </summary>
  /// <remarks>
  ///   Searches for text formatted with a specific style name.
  /// </remarks>
  public string? Style { get; set; }

  /// <summary>
  ///   Gets or sets the highlight color to search for.
  /// </summary>
  /// <remarks>
  ///   Searches for text with specific highlight color.
  /// </remarks>
  public ColorKind? Highlight { get; set; }

  /// <summary>
  ///   Gets or sets the language to search for.
  /// </summary>
  /// <remarks>
  ///   Searches for text formatted with a specific language ID.
  /// </remarks>
  public int? LanguageID { get; set; }

  /// <summary>
  ///   Gets or sets whether to search for any formatting.
  /// </summary>
  /// <remarks>
  ///   When true, finds any text that has direct formatting applied (not just style formatting).
  /// </remarks>
  public bool Format { get; set; }

  #endregion

  #region Replacement Options

  /// <summary>
  ///   Gets the replacement object for specifying replacement formatting.
  /// </summary>
  /// <remarks>
  ///   Used to specify formatting that should be applied to replacement text.
  /// </remarks>
  public Replacement? Replacement { get; }

  /// <summary>
  ///   Gets or sets whether to preserve formatting when replacing.
  /// </summary>
  /// <remarks>
  ///   When true, the replacement text adopts the formatting of the found text.
  /// </remarks>
  public bool PreserveFormatInReplace { get; set; }

  #endregion

  #region Search Range

  /// <summary>
  ///   Gets or sets whether the search includes document headers.
  /// </summary>
  public bool SearchHeaders { get; set; }

  /// <summary>
  ///   Gets or sets whether the search includes document footers.
  /// </summary>
  public bool SearchFooters { get; set; }

  /// <summary>
  ///   Gets or sets whether to search in hidden text.
  /// </summary>
  public bool SearchHiddenText { get; set; }

  /// <summary>
  ///   Gets or sets whether to search in field codes.
  /// </summary>
  public bool SearchFieldCodes { get; set; }

  /// <summary>
  ///   Gets or sets whether to search in field results.
  /// </summary>
  public bool SearchFieldResults { get; set; }

  #endregion

  #region Execution Methods

  /// <summary>
  ///   Executes the find operation.
  /// </summary>
  /// <param name="findText">Optional text to find (overrides Text property).</param>
  /// <param name="matchCase">Optional case sensitivity setting.</param>
  /// <param name="matchWholeWord">Optional whole word matching setting.</param>
  /// <param name="matchWildcards">Optional wildcard matching setting.</param>
  /// <param name="matchSoundsLike">Optional phonetic matching setting.</param>
  /// <param name="matchAllWordForms">Optional word forms matching setting.</param>
  /// <param name="forward">Optional search direction.</param>
  /// <param name="wrap">Optional wrap behavior.</param>
  /// <param name="format">Optional format searching.</param>
  /// <param name="replaceWith">Optional replacement text.</param>
  /// <param name="replace">Optional replacement mode.</param>
  /// <returns>True if the text or formatting was found.</returns>
  public bool Execute(
    string? findText = null,
    bool? matchCase = null,
    bool? matchWholeWord = null,
    bool? matchWildcards = null,
    bool? matchSoundsLike = null,
    bool? matchAllWordForms = null,
    bool? forward = null,
    WrapKind? wrap = null,
    bool? format = null,
    string? replaceWith = null,
    ReplaceKind? replace = null);

  /// <summary>
  ///   Executes a find and replace operation.
  /// </summary>
  /// <param name="findText">Text to find.</param>
  /// <param name="replaceWith">Replacement text.</param>
  /// <param name="replace">Replacement mode (one, all).</param>
  /// <returns>True if at least one replacement was made.</returns>
  public bool ExecuteReplace(string findText, string replaceWith, ReplaceKind replace);

  /// <summary>
  ///   Finds the next occurrence based on current settings.
  /// </summary>
  /// <returns>True if found.</returns>
  public bool FindNext();

  /// <summary>
  ///   Finds the previous occurrence based on current settings.
  /// </summary>
  /// <returns>True if found.</returns>
  public bool FindPrevious();

  #endregion

  #region Clear and Reset

  /// <summary>
  ///   Clears all find and replace criteria.
  /// </summary>
  /// <remarks>
  ///   Resets all search options, text, and formatting to default values.
  /// </remarks>
  public void ClearAllFormattingCriteria();

  /// <summary>
  ///   Clears the find formatting criteria.
  /// </summary>
  public void ClearFindFormatting();

  /// <summary>
  ///   Clears the replacement formatting criteria.
  /// </summary>
  public void ClearReplaceFormatting();

  /// <summary>
  ///   Resets the find object to default settings.
  /// </summary>
  public void Reset();

  #endregion

  #region Status Properties

  /// <summary>
  ///   Gets whether a match was found in the last operation.
  /// </summary>
  public bool Found { get; }

  /// <summary>
  ///   Gets the parent range object.
  /// </summary>
  public Range? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion

  #region Advanced Features

  /// <summary>
  ///   Sets the search range to a specific story type.
  /// </summary>
  /// <param name="storyType">The type of story to search in.</param>
  public void SetSearchStory(StoryKind storyType);

  /// <summary>
  ///   Gets or sets the frame formatting to search for.
  /// </summary>
  public Frame? Frame { get; set; }

  /// <summary>
  ///   Gets or sets whether to correct hanging Korean characters.
  /// </summary>
  public bool CorrectHangulEndings { get; set; }

  /// <summary>
  ///   Gets or sets whether to match byte characters in double-byte languages.
  /// </summary>
  public bool MatchByte { get; set; }

  /// <summary>
  ///   Gets or sets whether to match full-width/half-width forms in Asian text.
  /// </summary>
  public bool MatchFullHalfForms { get; set; }

  /// <summary>
  ///   Gets or sets whether to match phonetic guides (ruby text) in Asian languages.
  /// </summary>
  public bool MatchPhoneticGuides { get; set; }

  /// <summary>
  ///   Gets or sets the font size comparison operator.
  /// </summary>
  public ComparisonOperatorKind? FontSizeComparison { get; set; }

  /// <summary>
  ///   Gets or sets the font size value to compare against.
  /// </summary>
  public float? FontSize { get; set; }

  #endregion
}