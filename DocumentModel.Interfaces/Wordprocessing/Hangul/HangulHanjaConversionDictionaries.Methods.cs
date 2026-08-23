namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries?view=word-pia"/>
public partial interface IHangulHanjaConversionDictionaries : IModelObject
{
  /// <summary>
  /// Adds a Hangul/Hanja conversion dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the conversion dictionary file.</param>
  /// <returns>The created <see cref="IDictionary"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulhanjaconversiondictionaries.add?view=word-pia"/>
  public IDictionary Add(string FileName);
}
