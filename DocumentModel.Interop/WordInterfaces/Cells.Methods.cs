namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells?view=word-pia"/>
public partial interface ICells
{
  /// <summary>
  /// Adds a cell to the collection before the specified cell.
  /// </summary>
  /// <param name="BeforeCell">The cell before which the new cell is added.</param>
  /// <returns>The newly added <see cref="Cell"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.add?view=word-pia"/>
  public Cell Add(object BeforeCell);
}
