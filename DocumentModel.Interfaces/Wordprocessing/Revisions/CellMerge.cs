namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a revision for vertically merged or split table cells in a WordprocessingML document.
/// This interface provides properties for the current and original vertical merge state, author, date, and annotation identifier, enabling tracking and management of cell merge and split revisions in tables.
/// </summary>
public interface CellMerge: IdentifiedChange
{
  /// <summary>
  /// Current vertical merge revision state for the table cell (e.g., continue, restart, none).
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMerge { get; set; }

  /// <summary>
  /// Original vertical merge revision state for the table cell before the change.
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMergeOriginal { get; set; }

}