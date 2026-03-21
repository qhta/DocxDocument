namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Dictionary objects that includes the active custom spelling dictionaries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries?view=word-pia"/>
public partial interface Dictionaries : InteropObject, InteropCollection<Dictionary>
{
  /// <summary>
  /// The maximum.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.maximum?view=word-pia"/>
  public int Maximum { get; }

  /// <summary>
  /// The active custom dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.activecustomdictionary?view=word-pia"/>
  public Dictionary ActiveCustomDictionary { get; set; }
}
