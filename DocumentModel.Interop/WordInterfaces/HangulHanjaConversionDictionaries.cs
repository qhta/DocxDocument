namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Dictionary objects that includes the active custom Hangul-Hanja conversion dictionaries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries?view=word-pia"/>
public partial interface HangulHanjaConversionDictionaries : InteropObject, InteropCollection<Dictionary>
{
  /// <summary>
  /// The maximum.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.maximum?view=word-pia"/>
  public int Maximum { get; }

  /// <summary>
  /// The active custom dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.activecustomdictionary?view=word-pia"/>
  public Dictionary ActiveCustomDictionary { get; set; }

  /// <summary>
  /// The builtin dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.builtindictionary?view=word-pia"/>
  public Dictionary BuiltinDictionary { get; }
}
