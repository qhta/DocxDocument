namespace DocumentModel.Interop.Word;

public partial interface Cells
{
  /// <summary>
  /// Adds a cell to the collection before the specified cell.
  /// </summary>
  /// <param name="BeforeCell">The cell before which the new cell is added.</param>
  /// <returns>The newly added <see cref="Cell"/> object.</returns>
  public Cell Add(object BeforeCell);
}
