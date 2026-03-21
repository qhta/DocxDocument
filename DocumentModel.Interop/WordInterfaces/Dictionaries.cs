namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Dictionary objects that includes the active custom spelling dictionaries.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries?view=word-pia"/>
public partial interface Dictionaries : InteropObject, InteropCollection<Dictionary>
{
  /// <summary>
  /// The maximum.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.maximum?view=word-pia"/>
  public int Maximum { get; }

  /// <summary>
  /// The active custom dictionary.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.activecustomdictionary?view=word-pia"/>
  public Dictionary ActiveCustomDictionary { get; set; }
}
