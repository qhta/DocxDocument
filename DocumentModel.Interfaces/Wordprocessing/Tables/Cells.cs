namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of cells in a table row.
/// </summary>
public interface Cells : ElementCollection<Cell>
{
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