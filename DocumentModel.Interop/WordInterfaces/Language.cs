namespace DocumentModel.Interop;

/// <summary>
/// Represents a language used for proofing or formatting in Microsoft Word.
/// </summary>
public interface Language : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  public WdLanguageID ID { get; }
  /// <summary>
  /// The name local.
  /// </summary>
  public string NameLocal { get; }
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The active grammar dictionary.
  /// </summary>
  public Dictionary ActiveGrammarDictionary { get; }
  /// <summary>
  /// The active hyphenation dictionary.
  /// </summary>
  public Dictionary ActiveHyphenationDictionary { get; }
  /// <summary>
  /// The active spelling dictionary.
  /// </summary>
  public Dictionary ActiveSpellingDictionary { get; }
  /// <summary>
  /// The active thesaurus dictionary.
  /// </summary>
  public Dictionary ActiveThesaurusDictionary { get; }
  /// <summary>
  /// The default writing style.
  /// </summary>
  public string DefaultWritingStyle { get; set; }
  /// <summary>
  /// The writing style list.
  /// </summary>
  public object WritingStyleList { get; }
  /// <summary>
  /// The spelling dictionary type.
  /// </summary>
  public WdDictionaryType SpellingDictionaryType { get; set; }

}
