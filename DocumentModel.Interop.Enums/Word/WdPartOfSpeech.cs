namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the part of speech that a word represents when returned by the Word thesaurus service.
/// </summary>
public enum WdPartOfSpeech
{
  /// <summary>
  /// An adjective.
  /// </summary>
  Adjective = unchecked((int)0),
  /// <summary>
  /// A noun.
  /// </summary>
  Noun = unchecked((int)1),
  /// <summary>
  /// An adverb.
  /// </summary>
  Adverb = unchecked((int)2),
  /// <summary>
  /// A verb.
  /// </summary>
  Verb = unchecked((int)3),
  /// <summary>
  /// A pronoun.
  /// </summary>
  Pronoun = unchecked((int)4),
  /// <summary>
  /// A conjunction.
  /// </summary>
  Conjunction = unchecked((int)5),
  /// <summary>
  /// A preposition.
  /// </summary>
  Preposition = unchecked((int)6),
  /// <summary>
  /// An interjection.
  /// </summary>
  Interjection = unchecked((int)7),
  /// <summary>
  /// An idiom.
  /// </summary>
  Idiom = unchecked((int)8),
  /// <summary>
  /// Some other part of speech. [System.Runtime.InteropServices.Guid("6AF6E882-A139-3B8E-9B1C-3315A1AF366D")]
  /// public enum WdPartOfSpeech ﾉ Expand table
  /// </summary>
  Other = unchecked((int)9)
}
