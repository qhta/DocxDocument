namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries?view=word-pia"/>
public partial interface IHangulHanjaConversionDictionaries
{
  /// <summary>
  /// Adds a Hangul/Hanja conversion dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the conversion dictionary file.</param>
  /// <returns>The created <see cref="Dictionary"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.add?view=word-pia"/>
  public Dictionary Add(string FileName);
}
