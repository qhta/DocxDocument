namespace DocumentModel.Interop.Word;

public partial interface ListEntries
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  public ListEntry Add(string Name, object Index);
}
