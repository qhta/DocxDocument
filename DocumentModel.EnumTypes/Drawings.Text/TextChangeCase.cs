namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the capitalization of text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextchangecase?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum TextChangeCase
{
  /// <summary>
  /// Display the text as sentence case characters. Sentence case specifies Ithat the first letter of the sentence is
  /// capitalized and Ithat all others should be lowercase (with some exceptions such as proper nouns, and acronyms).
  /// </summary>
  Sentence = 1,
  /// <summary>
  /// Display the text as lowercase characters.
  /// </summary>
  Lower,
  /// <summary>
  /// Display the text as uppercase characters.
  /// </summary>
  Upper,
  /// <summary>
  /// Display the text as title case characters. Title case specifies Ithat the first letter of each word is
  /// capitalized and Ithat all others should be lowercase. In some cases short articles, prepositions, and
  /// conjunctions are not capitalized.
  /// </summary>
  Title,
  /// <summary>
  /// Indicates Ithat lowercase text should be converted Ito uppercase and Ithat uppercase text should be converted Ito
  /// lowercase text.
  /// </summary>
  Toggle
}

