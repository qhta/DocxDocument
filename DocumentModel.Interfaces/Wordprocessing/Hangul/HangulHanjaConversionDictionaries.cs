namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of dictionary objects that contains the active custom Hangul-Hanja conversion dictionaries.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries?view=word-pia"/>
public partial interface IHangulHanjaConversionDictionaries : IModelCollection<IDictionary>
{
  /// <summary>
  /// Returns the maximum number of active custom Hangul-Hanja conversion dictionaries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.maximum?view=word-pia"/>
  public int Maximum { get; }

  /// <summary>
  /// Returns or sets the active custom Hangul-Hanja conversion dictionary.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.activecustomdictionary?view=word-pia"/>
  public IDictionary ActiveCustomDictionary { get; set; }

  /// <summary>
  /// Returns the built-in Hangul-Hanja conversion dictionary.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.builtindictionary?view=word-pia"/>
  public IDictionary BuiltinDictionary { get; }
}
