namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the part of speech that a word represents when returned by the Word thesaurus service.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpartofspeech?view=office-pia` for Office interop details.
/// </remarks>
public enum PartOfSpeech
{
  /// <summary>
  /// An adjective.
  /// </summary>
  Adjective = 0,
  /// <summary>
  /// A noun.
  /// </summary>
  Noun = 1,
  /// <summary>
  /// An adverb.
  /// </summary>
  Adverb = 2,
  /// <summary>
  /// A verb.
  /// </summary>
  Verb = 3,
  /// <summary>
  /// A pronoun.
  /// </summary>
  Pronoun = 4,
  /// <summary>
  /// A conjunction.
  /// </summary>
  Conjunction = 5,
  /// <summary>
  /// A preposition.
  /// </summary>
  Preposition = 6,
  /// <summary>
  /// An interjection.
  /// </summary>
  Interjection = 7,
  /// <summary>
  /// An idiom.
  /// </summary>
  Idiom = 8,
  /// <summary>
  /// Some other part of speech.
  /// </summary>
  Other = 9
}
