namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a language used for proofing or formatting in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language?view=word-pia"/>
public interface Language : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.id?view=word-pia"/>
  public WdLanguageID ID { get; }
  /// <summary>
  /// The name local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.namelocal?view=word-pia"/>
  public string NameLocal { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The active grammar dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activegrammardictionary?view=word-pia"/>
  public Dictionary ActiveGrammarDictionary { get; }
  /// <summary>
  /// The active hyphenation dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activehyphenationdictionary?view=word-pia"/>
  public Dictionary ActiveHyphenationDictionary { get; }
  /// <summary>
  /// The active spelling dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activespellingdictionary?view=word-pia"/>
  public Dictionary ActiveSpellingDictionary { get; }
  /// <summary>
  /// The active thesaurus dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activethesaurusdictionary?view=word-pia"/>
  public Dictionary ActiveThesaurusDictionary { get; }
  /// <summary>
  /// The default writing style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.defaultwritingstyle?view=word-pia"/>
  public string DefaultWritingStyle { get; set; }
  /// <summary>
  /// The writing style list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.writingstylelist?view=word-pia"/>
  public object WritingStyleList { get; }
  /// <summary>
  /// The spelling dictionary type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.spellingdictionarytype?view=word-pia"/>
  public WdDictionaryType SpellingDictionaryType { get; set; }

}
