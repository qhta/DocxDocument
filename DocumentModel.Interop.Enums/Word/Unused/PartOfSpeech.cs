namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the part of speech that a word represents when returned by the Word thesaurus service.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpartofspeech?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPartOfSpeech")]
public enum PartOfSpeech
{
  /// <summary>
  /// An adjective.
  /// </summary>
  [InteropEnumValue("wdAdjective")]
  Adjective = 0,
  /// <summary>
  /// A noun.
  /// </summary>
  [InteropEnumValue("wdNoun")]
  Noun = 1,
  /// <summary>
  /// An adverb.
  /// </summary>
  [InteropEnumValue("wdAdverb")]
  Adverb = 2,
  /// <summary>
  /// A verb.
  /// </summary>
  [InteropEnumValue("wdVerb")]
  Verb = 3,
  /// <summary>
  /// A pronoun.
  /// </summary>
  [InteropEnumValue("wdPronoun")]
  Pronoun = 4,
  /// <summary>
  /// A conjunction.
  /// </summary>
  [InteropEnumValue("wdConjunction")]
  Conjunction = 5,
  /// <summary>
  /// A preposition.
  /// </summary>
  [InteropEnumValue("wdPreposition")]
  Preposition = 6,
  /// <summary>
  /// An interjection.
  /// </summary>
  [InteropEnumValue("wdInterjection")]
  Interjection = 7,
  /// <summary>
  /// An idiom.
  /// </summary>
  [InteropEnumValue("wdIdiom")]
  Idiom = 8,
  /// <summary>
  /// Some other part of speech.
  /// </summary>
  [InteropEnumValue("wdOther")]
  Other = 9
}
