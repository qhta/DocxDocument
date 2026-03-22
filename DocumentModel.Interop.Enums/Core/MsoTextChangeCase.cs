namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of text.
/// </summary>
public enum MsoTextChangeCase
{
  /// <summary>
  /// Specifies the capitalization of text.
  /// </summary>
  msoCaseSentence = 1,
  /// <summary>
  /// Display the text as lowercase characters.
  /// </summary>
  msoCaseLower,
  /// <summary>
  /// Display the text as uppercase characters.
  /// </summary>
  msoCaseUpper,
  /// <summary>
  /// Display the text as title case characters. Title case specifies that the first letter of each word is
  /// capitalized and that all others should be lowercase. In some cases short articles, prepositions, and
  /// conjunctions are not capitalized.
  /// </summary>
  msoCaseTitle,
  /// <summary>
  /// Indicates that lowercase text should be converted to uppercase and that uppercase text should be converted to
  /// lowercase text.
  /// </summary>
  msoCaseToggle
}
