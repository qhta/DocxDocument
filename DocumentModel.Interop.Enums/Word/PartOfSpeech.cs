namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the part of speech that a word represents when returned by the Word thesaurus service.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpartofspeech?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPartOfSpeech")]
public enum PartOfSpeech
{
  /// <summary>
  /// An adjective.
  /// </summary>
  [WordInteropEnumValue("wdAdjective")]
  Adjective = 0,
  /// <summary>
  /// A noun.
  /// </summary>
  [WordInteropEnumValue("wdNoun")]
  Noun = 1,
  /// <summary>
  /// An adverb.
  /// </summary>
  [WordInteropEnumValue("wdAdverb")]
  Adverb = 2,
  /// <summary>
  /// A verb.
  /// </summary>
  [WordInteropEnumValue("wdVerb")]
  Verb = 3,
  /// <summary>
  /// A pronoun.
  /// </summary>
  [WordInteropEnumValue("wdPronoun")]
  Pronoun = 4,
  /// <summary>
  /// A conjunction.
  /// </summary>
  [WordInteropEnumValue("wdConjunction")]
  Conjunction = 5,
  /// <summary>
  /// A preposition.
  /// </summary>
  [WordInteropEnumValue("wdPreposition")]
  Preposition = 6,
  /// <summary>
  /// An interjection.
  /// </summary>
  [WordInteropEnumValue("wdInterjection")]
  Interjection = 7,
  /// <summary>
  /// An idiom.
  /// </summary>
  [WordInteropEnumValue("wdIdiom")]
  Idiom = 8,
  /// <summary>
  /// Some other part of speech.
  /// </summary>
  [WordInteropEnumValue("wdOther")]
  Other = 9
}
