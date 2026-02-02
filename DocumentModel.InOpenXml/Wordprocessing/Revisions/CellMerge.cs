namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a revision for vertically merged or split table cells in a WordprocessingML document.
/// This class provides properties for the current and original vertical merge state, author, date, and annotation identifier, enabling tracking and management of cell merge and split revisions in tables.
/// </summary>
[OpenXmlType(typeof(DXW.CellMerge))]
public partial class CellMerge : TrackChangeType<DXW.CellMerge>
{
 /// <summary>
 /// Current vertical merge revision state for the table cell (e.g., continue, restart, none).
 /// </summary>
 public VerticalMergeRevision? VerticalMerge { get; set; }
 /// <summary>
 /// Original vertical merge revision state for the table cell before the change.
 /// </summary>
 public VerticalMergeRevision? VerticalMergeOriginal { get; set; }
}