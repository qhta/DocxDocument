namespace DocumentModel.Interop;

public partial interface Columns
{
  /// <summary>
  /// Adds a column to the collection before the specified column.
  /// </summary>
  /// <param name="BeforeColumn">The column before which the new column is added.</param>
  /// <returns>The newly added <see cref="Column"/> object.</returns>
  public Column Add(object BeforeColumn);
}
