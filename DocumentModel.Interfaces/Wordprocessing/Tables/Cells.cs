namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of cells in a table row.
/// </summary>
public interface Cells : IElementCollection<Cell>
{
  #region Collection Properties

  /// <summary>
  ///   Gets the number of cells in the collection.
  /// </summary>
  public int Count { get; }

  /// <summary>
  ///   Gets the first cell in the collection.
  /// </summary>
  public Cell? First { get; }

  /// <summary>
  ///   Gets the last cell in the collection.
  /// </summary>
  public Cell? Last { get; }

  #endregion

  #region Item Access

  /// <summary>
  ///   Gets a cell by its index.
  /// </summary>
  /// <param name="index">The one-based index of the cell.</param>
  /// <returns>The cell at the specified index.</returns>
  public Cell? Item(int index);

  #endregion

  #region Methods

  /// <summary>
  ///   Adds a new cell to the collection.
  /// </summary>
  /// <returns>The newly created cell.</returns>
  public Cell Add();

  /// <summary>
  ///   Adds a new cell at the specified position.
  /// </summary>
  /// <param name="beforeCell">The cell before which to insert.</param>
  /// <returns>The newly created cell.</returns>
  public Cell Add(Cell beforeCell);

  #endregion

  #region Parent and Application

  /// <summary>
  ///   Gets the parent row.
  /// </summary>
  public Row? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}