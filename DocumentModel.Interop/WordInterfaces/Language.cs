namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a language used for proofing or formatting in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language?view=word-pia"/>
public interface Language : InteropObject
{
  /// <summary>
  /// Returns a language ID constant for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.id?view=word-pia"/>
  public LanguageID ID { get; }
  /// <summary>
  /// Returns the localized name of the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.namelocal?view=word-pia"/>
  public string NameLocal { get; }
  /// <summary>
  /// Returns the name of the language in English.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the active grammar dictionary for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activegrammardictionary?view=word-pia"/>
  public Dictionary ActiveGrammarDictionary { get; }
  /// <summary>
  /// Returns the active hyphenation dictionary for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activehyphenationdictionary?view=word-pia"/>
  public Dictionary ActiveHyphenationDictionary { get; }
  /// <summary>
  /// Returns the active spelling dictionary for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activespellingdictionary?view=word-pia"/>
  public Dictionary ActiveSpellingDictionary { get; }
  /// <summary>
  /// Returns the active thesaurus dictionary for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activethesaurusdictionary?view=word-pia"/>
  public Dictionary ActiveThesaurusDictionary { get; }
  /// <summary>
  /// Returns or sets the default writing style for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.defaultwritingstyle?view=word-pia"/>
  public string DefaultWritingStyle { get; set; }
  /// <summary>
  /// Returns the list of available writing styles for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.writingstylelist?view=word-pia"/>
  public object WritingStyleList { get; }
  /// <summary>
  /// Returns or sets the type of spelling dictionary used for the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.spellingdictionarytype?view=word-pia"/>
  public DictionaryType SpellingDictionaryType { get; set; }

}
