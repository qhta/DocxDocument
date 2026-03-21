namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries?view=word-pia"/>
public partial interface ListEntries
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries.add?view=word-pia"/>
  public ListEntry Add(string Name, object Index);
}
