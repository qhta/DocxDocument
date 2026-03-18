namespace DocumentModel.Interop;

public partial interface Rows
{
  /// <summary>
  /// Adds a new row before the specified row.
  /// </summary>
  /// <param name="BeforeRow">The row before which the new row is inserted.</param>
  /// <returns>The inserted <see cref="Row"/>.</returns>
  public Row Add(object BeforeRow);
}
