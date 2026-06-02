namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of dictionary objects that contains the active custom Hangul-Hanja conversion dictionaries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries?view=word-pia"/>
public partial class HangulHanjaConversionDictionaries : InteropCollection<Dictionary>
{
  /// <summary>
  /// Returns the maximum number of active custom Hangul-Hanja conversion dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.maximum?view=word-pia"/>
  public int Maximum { get; set; }

  /// <summary>
  /// Returns or sets the active custom Hangul-Hanja conversion dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.activecustomdictionary?view=word-pia"/>
  public Dictionary ActiveCustomDictionary { get; set; }

  /// <summary>
  /// Returns the built-in Hangul-Hanja conversion dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.builtindictionary?view=word-pia"/>
  public Dictionary BuiltinDictionary { get; set; }


  #region methods

/// <summary>
  /// Adds a Hangul/Hanja conversion dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the conversion dictionary file.</param>
  /// <returns>The created <see cref="Dictionary"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.add?view=word-pia"/>
  public Dictionary Add(string FileName) { throw new NotImplementedException(); }

  #endregion methods
}
