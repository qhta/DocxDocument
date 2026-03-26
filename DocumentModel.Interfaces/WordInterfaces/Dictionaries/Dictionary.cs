namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a dictionary.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary?view=word-pia"/>
public partial interface Dictionary : InteropObject
{
  /// <summary>
  /// Gets the name of the dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the path of the dictionary file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Gets or sets the language ID associated with the dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary.languageid?view=word-pia"/>
  public LanguageID LanguageID { get; set; }

  /// <summary>
  /// Gets a value indicating whether the dictionary is read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary.readonly?view=word-pia"/>
  public bool ReadOnly { get; }

  /// <summary>
  /// Gets the dictionary type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary.type?view=word-pia"/>
  public DictionaryType Type { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the dictionary is language-specific.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionary.languagespecific?view=word-pia"/>
  public bool LanguageSpecific { get; set; }
}
