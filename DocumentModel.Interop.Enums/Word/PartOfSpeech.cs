namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the part of speech that a word represents when returned by the Word thesaurus service.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpartofspeech?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPartOfSpeech))]
public enum PartOfSpeech
{
  /// <summary>
  /// An adjective.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdAdjective))]
  Adjective = 0,
  /// <summary>
  /// A noun.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdNoun))]
  Noun = 1,
  /// <summary>
  /// An adverb.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdAdverb))]
  Adverb = 2,
  /// <summary>
  /// A verb.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdVerb))]
  Verb = 3,
  /// <summary>
  /// A pronoun.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdPronoun))]
  Pronoun = 4,
  /// <summary>
  /// A conjunction.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdConjunction))]
  Conjunction = 5,
  /// <summary>
  /// A preposition.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdPreposition))]
  Preposition = 6,
  /// <summary>
  /// An interjection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdInterjection))]
  Interjection = 7,
  /// <summary>
  /// An idiom.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdIdiom))]
  Idiom = 8,
  /// <summary>
  /// Some other part of speech.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPartOfSpeech.wdOther))]
  Other = 9
}
