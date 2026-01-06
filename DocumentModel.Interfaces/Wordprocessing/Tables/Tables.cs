namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of tables in a document, section, range, or cell.
/// </summary>
public interface Tables : ElementCollection<Table>
{
  #region Collection Properties

  /// <summary>
  ///   Gets the number of tables in the collection.
  /// </summary>
  public int Count { get; }

  /// <summary>
  ///   Gets the first table in the collection.
  /// </summary>
  public Table? First { get; }

  /// <summary>
  ///   Gets the last table in the collection.
  /// </summary>
  public Table? Last { get; }

  #endregion

  #region Item Access

  /// <summary>
  ///   Gets a table by its index.
  /// </summary>
  /// <param name="index">The one-based index of the table.</param>
  /// <returns>The table at the specified index.</returns>
  public Table? Item(int index);

  #endregion

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

  #region Parent and Application

  /// <summary>
  ///   Gets the parent object.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}