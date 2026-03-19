namespace DocumentModel.Interop.Word;

public partial interface HangulHanjaConversionDictionaries
{
  /// <summary>
  /// Adds a Hangul/Hanja conversion dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the conversion dictionary file.</param>
  /// <returns>The created <see cref="Dictionary"/> object.</returns>
  public Dictionary Add(string FileName);
}
