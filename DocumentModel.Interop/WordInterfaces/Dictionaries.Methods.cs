namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries?view=word-pia"/>
public partial interface Dictionaries
{
  /// <summary>
  /// Adds a custom dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the custom dictionary.</param>
  /// <returns>The created <see cref="Dictionary"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.add?view=word-pia"/>
  public Dictionary Add(string FileName);
}
