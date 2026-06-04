namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextchangecase?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextChangeCase")]
public enum TextChangeCase
{
  /// <summary>
  /// Display the text as sentence case characters. Sentence case specifies that the first letter of the sentence is
  /// capitalized and that all others should be lowercase (with some exceptions such as proper nouns, and acronyms).
  /// </summary>
  [InteropEnumValue("msoCaseSentence")]
  Sentence = 1,
  /// <summary>
  /// Display the text as lowercase characters.
  /// </summary>
  [InteropEnumValue("msoCaseLower")]
  Lower,
  /// <summary>
  /// Display the text as uppercase characters.
  /// </summary>
  [InteropEnumValue("msoCaseUpper")]
  Upper,
  /// <summary>
  /// Display the text as title case characters. Title case specifies that the first letter of each word is
  /// capitalized and that all others should be lowercase. In some cases short articles, prepositions, and
  /// conjunctions are not capitalized.
  /// </summary>
  [InteropEnumValue("msoCaseTitle")]
  Title,
  /// <summary>
  /// Indicates that lowercase text should be converted to uppercase and that uppercase text should be converted to
  /// lowercase text.
  /// </summary>
  [InteropEnumValue("msoCaseToggle")]
  Toggle
}
