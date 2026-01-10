namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of tables in a document, section, range, or cell.
/// </summary>
public interface Tables : ElementCollection<Table>
{
  #region Methods

  /// <summary>
  ///   Adds a new table to the collection.
  /// </summary>
  /// <param name="range">The range where the table should be inserted.</param>
  /// <param name="numRows">Number of rows.</param>
  /// <param name="numColumns">Number of columns.</param>
  /// <returns>The newly created table.</returns>
  public Table Add(Range range, int numRows, int numColumns);

  #endregion

}