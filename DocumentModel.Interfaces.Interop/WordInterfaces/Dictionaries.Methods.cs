namespace DocumentModel.Interop;

public partial interface Dictionaries
{
  /// <summary>
  /// Adds a custom dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the custom dictionary.</param>
  /// <returns>The created <see cref="Dictionary"/> object.</returns>
  public Dictionary Add(string FileName);
}
