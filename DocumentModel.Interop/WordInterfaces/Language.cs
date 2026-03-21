namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a language used for proofing or formatting in Microsoft Word.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language?view=word-pia"/>
public interface Language : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.id?view=word-pia"/>
  public WdLanguageID ID { get; }
  /// <summary>
  /// The name local.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.namelocal?view=word-pia"/>
  public string NameLocal { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The active grammar dictionary.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activegrammardictionary?view=word-pia"/>
  public Dictionary ActiveGrammarDictionary { get; }
  /// <summary>
  /// The active hyphenation dictionary.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activehyphenationdictionary?view=word-pia"/>
  public Dictionary ActiveHyphenationDictionary { get; }
  /// <summary>
  /// The active spelling dictionary.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activespellingdictionary?view=word-pia"/>
  public Dictionary ActiveSpellingDictionary { get; }
  /// <summary>
  /// The active thesaurus dictionary.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.activethesaurusdictionary?view=word-pia"/>
  public Dictionary ActiveThesaurusDictionary { get; }
  /// <summary>
  /// The default writing style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.defaultwritingstyle?view=word-pia"/>
  public string DefaultWritingStyle { get; set; }
  /// <summary>
  /// The writing style list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.writingstylelist?view=word-pia"/>
  public object WritingStyleList { get; }
  /// <summary>
  /// The spelling dictionary type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.language.spellingdictionarytype?view=word-pia"/>
  public WdDictionaryType SpellingDictionaryType { get; set; }

}
