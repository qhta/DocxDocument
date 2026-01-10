namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of cells in a table row within a Wordprocessing document.
/// This interface provides access to the parent row and application object, enabling management and navigation of cell collections in table structures.
/// </summary>
public interface Cells : ElementCollection<Cell>
{
  /// <summary>
  /// Parent row containing this collection of cells.
  /// </summary>
  public Row? Parent { get; }

  /// <summary>
  /// Application object associated with this collection of cells.
  /// </summary>
  public Application? Application { get; }
}